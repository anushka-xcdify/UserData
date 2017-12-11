using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using usermanagement.Mapper.Users;
using usermanagement.Models.Entity.Users;


namespace usermanagement.Context.Users
{
    public class UsersAddressContext : IUsersAddressContext
    {
        string connectionString;
        UsersMapper usersMapper;

        public UsersAddressContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public List<UsersAddressEntity> Get()
        {
            var users = new List<UsersAddressEntity>();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT * FROM UserAddress", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        users.Add(new UsersAddressEntity()
                        {
                            UserID = dr.GetInt32(1),
                            Address1 = dr.GetString(2),
                            Address2 = dr.GetString(3),
                            City = dr.GetString(4),
                            State = dr.GetString(5),
                            Country = dr.GetString(6),
                            Zip = dr.GetInt32(7),
                            PrimaryAddress = dr.GetBoolean(8)
                        });
                    }
                }
            }

            return users;
        }

        public UsersAddressEntity Get(int id)
        {
            var users = new UsersAddressEntity();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT * FROM UserAddress WHERE id= @id", con);
                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        users.UserID = dr.GetInt32(1);
                        users.Address1 = dr.GetString(2);
                        users.Address2 = dr.GetString(3);
                        users.City = dr.GetString(4);
                        users.State = dr.GetString(5);
                        users.Country = dr.GetString(6);
                        users.Zip = dr.GetInt32(7);
                        users.PrimaryAddress = dr.GetBoolean(8);
                    }
                }
            }

            return users;
        }

        public bool Create(int id, UsersAddressEntity user)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("INSERT INTO UserAddress (UserId,Address1,Address2,City,State,Country,Zip,PrimaryAddress) Values (@UserId,@address1,@address2,@city,@state,@country,@zip,@primary)", con);
                cmd.Parameters.AddWithValue("@UserId", id);
                cmd.Parameters.AddWithValue("@address1", user.Address1);
                cmd.Parameters.AddWithValue("@address2", user.Address2);
                cmd.Parameters.AddWithValue("@city", user.City);
                cmd.Parameters.AddWithValue("@state", user.State);
                cmd.Parameters.AddWithValue("@country", user.Country);
                cmd.Parameters.AddWithValue("@zip", user.Zip);
                cmd.Parameters.AddWithValue("@primary", user.PrimaryAddress);

                int n = cmd.ExecuteNonQuery();

                return n > 0;

            }
        }

        public bool Delete(int id)
        {
            var users = new UsersAddressEntity();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("DELETE FROM UserAddress WHERE id= @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                int n = cmd.ExecuteNonQuery();

                return n > 0;
            }
        }

        public bool Update(int UserId, int id, UsersAddressEntity user)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("UPDATE UserAddress SET UserId=@UserId,Address1=@address1,Address2=@address2,City=@city,State=@state,Country=@country,Zip=@zip, PrimaryAddress=@primary WHERE id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@address1", user.Address1);
                cmd.Parameters.AddWithValue("@address2", user.Address2);
                cmd.Parameters.AddWithValue("@city", user.City);
                cmd.Parameters.AddWithValue("@state", user.State);
                cmd.Parameters.AddWithValue("@country", user.Country);
                cmd.Parameters.AddWithValue("@zip", user.Zip);
                cmd.Parameters.AddWithValue("@primary", user.PrimaryAddress);

                int n = cmd.ExecuteNonQuery();

                return n > 0;
            }
        }
    }
}