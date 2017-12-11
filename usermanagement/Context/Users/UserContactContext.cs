using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using usermanagement.Mapper.Users;
using usermanagement.Models.Entity.Users;


namespace usermanagement.Context.Users
{
    public class UserContactContext : IUserContactContext
    {
        string connectionString;
        UsersMapper usersMapper;

        public UserContactContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public List<UserContactEntity> Get()
        {
            var user = new List<UserContactEntity>();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT * FROM UserContact", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        user.Add(new UserContactEntity()
                        {
                            UserID = dr.GetInt32(1),
                            ContactType = dr.GetString(2),
                            ContactValue = dr.GetString(3),
                            PrimaryContact = dr.GetBoolean(4)
                        });
                    }
                }
            }
            return user;
        }

        public UserContactEntity Get(int id)
        {
            var user = new UserContactEntity();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT * FROM UserContact WHERE id= @id", con);
                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        user.UserID = dr.GetInt32(1);
                        user.ContactType = dr.GetString(2);
                        user.ContactValue = dr.GetString(3);
                        user.PrimaryContact = dr.GetBoolean(4);
                    }
                }
            }

            return user;
        }

        public bool Create(int id, UserContactEntity user)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("INSERT INTO UserContact (UserId,Type,Value,PrimaryContact) Values (@UserId,@type,@value,@primary)", con);
                cmd.Parameters.AddWithValue("@UserId", id);
                cmd.Parameters.AddWithValue("@type", user.ContactType);
                cmd.Parameters.AddWithValue("@value", user.ContactValue);
                cmd.Parameters.AddWithValue("@primary", user.PrimaryContact);

                int n = cmd.ExecuteNonQuery();

                return n > 0;

            }
        }

        public bool Update(int UserId, int id, UserContactEntity user)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("UPDATE UserContact SET UserId=@UserId,Type=@type,Value=@value,PrimaryContact=@primary WHERE id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@type", user.ContactType);
                cmd.Parameters.AddWithValue("@value", user.ContactValue);
                cmd.Parameters.AddWithValue("@primary", user.PrimaryContact);

                int n = cmd.ExecuteNonQuery();

                return n > 0;
            }
        }

        public bool Delete(int id)
        {
            var users = new UserContactEntity();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("DELETE FROM UserContact WHERE id= @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                int n = cmd.ExecuteNonQuery();

                return n > 0;
            }
        }

    }
}