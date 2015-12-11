using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using ExpensesTrackerClient.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace ExpensesTrackerClient
{
    class WebApiHelper
    {
        #region Field

        private string _url = "";
        // Declare instace of HttpClient to be used by other members
        HttpClient client = new HttpClient();

        #endregion

        #region Constructor

        // Constructor takes URL of API as parameter and store in local var and 
        public WebApiHelper(string url)
        {
            client.BaseAddress = new Uri("http://localhost:23815/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _url = url;
        }

        #endregion

        #region Destructor

        ~WebApiHelper()
        {
            client.Dispose();
        }

        #endregion

        #region Members for Expenses Controller

        public IEnumerable<Expense> Get(string token, DateTime from, DateTime to)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization = 
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                IEnumerable<Expense> data = new List<Expense>();

                //api/expenses?from=2015-11-09T00:00:00&to=2015-11-15T00:00:00
                string fromStr = from.ToString("s", CultureInfo.InvariantCulture);
                string toStr = to.ToString("s", CultureInfo.InvariantCulture);
                string time = _url + "expenses?from=" + fromStr + "&to=" + toStr;
                HttpResponseMessage response = client.GetAsync(time).Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code
                if (response.IsSuccessStatusCode)
                {
                    data = response.Content.ReadAsAsync<List<Expense>>().Result;
                }
                return data;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        public IEnumerable<Expense> GetAll(string token)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization = 
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                IEnumerable<Expense> data = new List<Expense>();
                HttpResponseMessage response = client.GetAsync(_url + "expenses/all").Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code
                if (response.IsSuccessStatusCode)
                {
                    data = response.Content.ReadAsAsync<List<Expense>>().Result;
                }
                return data;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }


        public Expense Get(int id, string token)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                Expense expense = new Expense();
                string elem = String.Concat(_url + "expenses/", id);
                HttpResponseMessage response = client.GetAsync(elem).Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code

                if (response.IsSuccessStatusCode)
                {
                    expense = response.Content.ReadAsAsync<Expense>().Result;
                }
                
                return expense;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        public string Post(Expense obj, string token)
        {
            string result = "";

            client.DefaultRequestHeaders.Authorization = 
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = client.PostAsJsonAsync(_url + "expenses", obj).Result;

            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ToString();
            }
            else
            {
                var ex = CreateApiException(response);
                throw ex;
            }
            return result;

        }

        public string Put(Expense obj, string token)
        {
            string result = "";

            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            string elem = String.Concat(_url + "expenses/", obj.Id);
            HttpResponseMessage response = client.PutAsJsonAsync(elem, obj).Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ToString();
            }
            else
            {
                var ex = CreateApiException(response);
                throw ex;
            }
            return result;


        }

        public string Delete(int id, string token)
        {
            try
            {
                string result = "";
                client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = client.DeleteAsync(_url + "expenses/" + id).Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ToString();
                }
                
                return result;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        public string DeleteByAdmin(int id, string token)
        {
            try
            {
                string result = "";
                client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = client.DeleteAsync(_url + "expenses/" + id + "/admin").Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ToString();
                }

                return result;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        #endregion

        #region Member for Account controller

        public string Register(string username, string password, string confirmPassword, string firstname, string lastname, string email)
        {
            string result = "";
            var data = new Dictionary<string, string>
            {
                {"Username", username},
                {"FirstName", firstname},
                {"LastName", lastname},
                {"Email", email},
                {"Password", password},
                {"ConfirmPassword", confirmPassword}
            };

            HttpResponseMessage response = client.PostAsync(_url + "accounts/register", new FormUrlEncodedContent(data)).Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ToString();
            }
            else 
            {
                var ex = CreateApiException(response);
                throw ex;
            }
            return result;
        
        }

        public Dictionary<string, string> GetToken(string userName, string password)
        {
            var pairs = new List<KeyValuePair<string, string>>
                        {
                            new KeyValuePair<string, string>( "grant_type", "password" ), 
                            new KeyValuePair<string, string>( "username", userName ), 
                            new KeyValuePair<string, string> ( "Password", password )
                        };
            var content = new FormUrlEncodedContent(pairs);

            var response =
                client.PostAsync("http://localhost:23815/Token", content).Result;
            var result = response.Content.ReadAsStringAsync().Result;

            // Deserialize the JSON into a Dictionary<string, string>
            Dictionary<string, string> tokenDictionary =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            return tokenDictionary;

        }

        public ApplicationUser GetUserByUsername(string token, string username)
        {
            ApplicationUser result = new ApplicationUser();
            try
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = client.GetAsync(_url + "accounts/user/" + username).Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsAsync<ApplicationUser>().Result;
                }
                return result;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        public ApplicationUser GetUserById(string token, string id)
        {
            ApplicationUser result = new ApplicationUser();
            try
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = client.GetAsync(_url + "accounts/user/" + id).Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsAsync<ApplicationUser>().Result;
                }
                return result;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        public IEnumerable<ApplicationUser> GetAllUsers(string token)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                IEnumerable<ApplicationUser> data = new List<ApplicationUser>();
                HttpResponseMessage response = client.GetAsync(_url + "accounts/users").Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code
                if (response.IsSuccessStatusCode)
                {
                    data = response.Content.ReadAsAsync<List<ApplicationUser>>().Result;
                }
                return data;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        public string DeleteUser(string id, string token)
        {
            try
            {
                string result = "";
                client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = client.DeleteAsync(_url + "accounts/user/" + id).Result;
                response.EnsureSuccessStatusCode(); // Throw if not success code
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ToString();
                }

                return result;
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        public string ChangePassword(string oldPassword, string password, string confirmPassword, string token)
        {
            string result = "";
            var data = new Dictionary<string, string>
            {
                {"OldPassword", oldPassword},
                {"NewPassword", password},
                {"ConfirmPassword", confirmPassword}
            };

            client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = 
                client.PostAsync(_url + "accounts/ChangePassword", new FormUrlEncodedContent(data)).Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ToString();
            }
            else 
            {
                var ex = CreateApiException(response);
                throw ex;
            }
            return result;
        }

        public string AssignRolesToUser(string id, string[] roles, string token)
        {
            string result = "";

            client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = 
                client.PostAsJsonAsync<string[]>(_url + "accounts/user/" + id + "/roles", roles).Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ToString();
            }
            else
            {
                var ex = CreateApiException(response);
                throw ex;
            }
            return result;
        }

        public IEnumerable<RoleReturnModel> GetAllRoles(string token)
        {
            

            client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            IEnumerable<RoleReturnModel> data = new List<RoleReturnModel>();
            HttpResponseMessage response = client.GetAsync(_url + "roles").Result;
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsAsync<List<RoleReturnModel>>().Result;
            }
            else
            {
                var ex = CreateApiException(response);
                throw ex;
            }
            return data;
        }

        #endregion

        #region Helper

        public static ApiException CreateApiException(HttpResponseMessage response)
        {
            var httpErrorObject = response.Content.ReadAsStringAsync().Result;

            // Create an anonymous object to use as the template for deserialization:
            var anonymousErrorObject =
                new { message = "", ModelState = new Dictionary<string, string[]>() };

            // Deserialize:
            var deserializedErrorObject =
                JsonConvert.DeserializeAnonymousType(httpErrorObject, anonymousErrorObject);

            // Now wrap into an exception which best fullfills the needs of your application:
            var ex = new ApiException(response);

            // Sometimes, there may be Model Errors:
            if (deserializedErrorObject.ModelState != null)
            {
                var errors =
                    deserializedErrorObject.ModelState
                                            .Select(kvp => string.Join(". ", kvp.Value));
                for (int i = 0; i < errors.Count(); i++)
                {
                    // Wrap the errors up into the base Exception.Data Dictionary:
                    ex.Data.Add(i, errors.ElementAt(i));
                }
            }
            // Othertimes, there may not be Model Errors:
            else
            {
                var error =
                    JsonConvert.DeserializeObject<Dictionary<string, string>>(httpErrorObject);
                foreach (var kvp in error)
                {
                    // Wrap the errors up into the base Exception.Data Dictionary:
                    ex.Data.Add(kvp.Key, kvp.Value);
                }
            }
            return ex;
        }

        #endregion
    }
}
