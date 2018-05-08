using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibansach
{
    static class Program
    {
        public static User user;
        public static String rootName = "Tất cả";

        public static String image_address = "https://sledge-hammer-liquo.000webhostapp.com/public/img/";

        private static String server_address = "http://cuongmanh2311.000webhostapp.com/";
        

        public static String path_AllCategories = server_address + "categories";
        public static String path_AllProducts = server_address + "products/getall";
        public static String path_productsFromCategory = server_address + "products/cate_product?cate_id=";
        public static String path_storeProduct = server_address + "products/store";
        public static String path_updateProduct = server_address + "products/update";
        public static String path_destroyProduct = server_address + "products/destroy/";
        public static String path_signin = server_address + "users/login";
        public static String path_AllPermission = server_address + "permission";
        public static String path_getPermissionbelow = server_address + "users/permission";
        public static String path_getPermission = server_address + "permission/show/";
        public static String path_storeUser = server_address + "users/store";
        public static String path_updateUser = server_address + "users/update";
        public static String path_destroyUser = server_address + "users/destroy/";
        public static String path_getUserbelow = server_address + "users/user_permission";
        public static String path_storeCategory = server_address + "categories/store";
        public static String path_updateCategory = server_address + "categories/update";
        public static String path_destroyCategory = server_address + "categories/destroy/";
        public static String path_AllRent = server_address + "rent";
        public static String path_storeRent = server_address + "rent/store";
        public static String path_updateRent = server_address + "rent/update";
        public static String path_destroyRent = server_address + "rent/destroy/";
        public static String path_storePermission = server_address + "permission/store";
        public static String path_updatePermission = server_address + "permission/update";
        public static String path_destroyPermission = server_address + "permission/destroy/";

        public static Category[] getAllCategory()
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(Program.path_AllCategories);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Category[]));
                object responseData = json.ReadObject(response.GetResponseStream());
                return responseData as Category[];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static Product[] getProductfromURL(String url)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Product[]));
                object responseData = json.ReadObject(response.GetResponseStream());
                return responseData as Product[];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static Permission[] getPermissionbelow(String role)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(Program.path_getPermissionbelow + "?role=" + role);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Permission[]));
                object responseData = json.ReadObject(response.GetResponseStream());
                return responseData as Permission[];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static Permission[] getAllPermission()
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(Program.path_AllPermission);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Permission[]));
                object responseData = json.ReadObject(response.GetResponseStream());
                return responseData as Permission[];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static Permission getPermission(int id)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(Program.path_getPermission + id);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Permission));
                object responseData = json.ReadObject(response.GetResponseStream());
                return responseData as Permission;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static User[] getUserbelow(String role)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(Program.path_getUserbelow + "?role=" + role);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(User[]));
                object responseData = json.ReadObject(response.GetResponseStream());
                return responseData as User[];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static Rent[] getAllRent()
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(Program.path_AllRent);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Rent[]));
                object responseData = json.ReadObject(response.GetResponseStream());
                return responseData as Rent[];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static void sendRequest(HttpWebRequest request)
        {
            try
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(BooleanResponse));
                object responseData = json.ReadObject(request.GetResponse().GetResponseStream());
                bool kq = (responseData as BooleanResponse).status;
                if (!kq)
                {
                    throw new Exception("Error has been detected");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void sendRequest(HttpWebRequest request, String method, String para)
        {
            try
            {
                request.Method = method;
                request.ContentType = "application/json;charset=UTF-8";
                byte[] arr = Encoding.UTF8.GetBytes(para);
                request.ContentLength = arr.Length;
                Stream stream = request.GetRequestStream();
                stream.Write(arr, 0, arr.Length);
                stream.Close();
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(BooleanResponse));
                object responseData = json.ReadObject(request.GetResponse().GetResponseStream());
                bool kq = (responseData as BooleanResponse).status;
                if (!kq)
                {
                    throw new Exception("Error has been detected");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void signin(String email, String password)
        {
            try
            {
                String para = "?email=" + email + "&password=" + password;
                String url = path_signin + para;
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = "POST";
                request.ContentType = "application/json;charset=UTF-8";
                byte[] arr = Encoding.UTF8.GetBytes(para);
                request.ContentLength = arr.Length;
                Stream stream = request.GetRequestStream();
                stream.Write(arr, 0, arr.Length);
                stream.Close();
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(User));
                object responseData = json.ReadObject(request.GetResponse().GetResponseStream());
                User user = responseData as User;
                if (user.email == null)
                {
                    throw new Exception("Error has been detected");
                }
                else if (int.Parse(user.role) > 3)
                {
                    throw new Exception("Customer không thể đăng nhập vào ứng dụng");
                }
                Program.user = user;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        [STAThread]
        static void Main()
        {

            DevExpress.UserSkins.BonusSkins.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
