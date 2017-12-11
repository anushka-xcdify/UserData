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
    public class UsersContext : IUsersContext
    {
        string connectionString;
        UsersMapper usersMapper;

        public UsersContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            usersMapper = new UsersMapper();
        }
        
        public List<UsersEntity> Get()
        {
            var users = new List<UsersEntity>();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT * FROM UserDetails", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        users.Add(usersMapper.mapUsers(dr));
                    }
                }
            }
            
            return users;
        }

        public UsersEntity Get(int id)
        {
            var users = new UsersEntity();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT * FROM UserDetails WHERE id= @id", con);
                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        users.UserID = dr.GetString(1);
                        users.FirstName = dr.GetString(2);
                        users.LastName = dr.GetString(3);
                        users.Gender = dr.GetString(4);
                        users.DOB = Convert.ToDateTime(dr[5]);
                        users.IsActive = dr.GetBoolean(6);
                        users.CreateDate = Convert.ToDateTime(dr[7]);
                    }
                }
            }

            return users;
        }

        public bool Create(UsersEntity usersEntity)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
       
                var cmd = new SqlCommand("INSERT INTO UserDetails (UserId,FirstName,LastName,Gender,DOB,IsActive,CreateDate) Values (@UserId,@FirstName,@LastName,@Gender,@DOB,@IsActive,@CreateDate)", con);
                cmd.Parameters.AddWithValue("@UserId", usersEntity.UserID);
                cmd.Parameters.AddWithValue("@FirstName", usersEntity.FirstName);
                cmd.Parameters.AddWithValue("@LastName", usersEntity.LastName);
                cmd.Parameters.AddWithValue("@Gender", usersEntity.Gender);
                cmd.Parameters.AddWithValue("@DOB", usersEntity.DOB);
                cmd.Parameters.AddWithValue("@IsActive", usersEntity.IsActive);
                cmd.Parameters.AddWithValue("@CreateDate", usersEntity.CreateDate);

                int n = cmd.ExecuteNonQuery();

                return n > 0;

            }
        }

        public bool Update(int id, UsersEntity usersEntity)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("UPDATE UserDetails SET UserId=@UserId,FirstName=@FirstName,LastName=@LastName,Gender=@Gender,DOB=@DOB,IsActive=@IsActive,CreateDate=@CreateDate WHERE id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@UserId", usersEntity.UserID);
                cmd.Parameters.AddWithValue("@FirstName", usersEntity.FirstName);
                cmd.Parameters.AddWithValue("@LastName", usersEntity.LastName);
                cmd.Parameters.AddWithValue("@Gender", usersEntity.Gender);
                cmd.Parameters.AddWithValue("@DOB", usersEntity.DOB);
                cmd.Parameters.AddWithValue("@IsActive", usersEntity.IsActive);
                cmd.Parameters.AddWithValue("@CreateDate", usersEntity.CreateDate);

                int n = cmd.ExecuteNonQuery();

                return n > 0;
            }
        }

        public bool Delete(int id)
        {
            var users = new UsersEntity();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("DELETE FROM UserDetails WHERE id= @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                int n = cmd.ExecuteNonQuery();

                return n > 0;
            }
        }
    }
}