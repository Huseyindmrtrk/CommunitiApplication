using CommunitiApp.İnfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using DapperExtensions;
using DapperExtensions.Sql;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CommunitiApp.Models
{
    public class Communiti
    {
        public int Id { get; set; }
        public string CommunitiName { get; set; }
        public bool IsDeleted { get; set; }

        /// <summary>
        /// insert a new Communiti entity or updates 
        /// </summary>
        /// <returns></returns>
        public Int64 Save()
        {
            Int64 r = -1;

            var conn = DAL.GetConnection();
            conn.Open();

            if(this.Id == 0)
            {
                
            }
            else
            {
                var record = conn.Get<Communiti>(this.Id);
                record.CommunitiName = this.CommunitiName;
                var isUpdated = conn.Update<Communiti>(record);
                if (isUpdated)
                {
                    r = this.Id;
                }
                
            }
            conn.Close();
            return r;

        }
        public List<Communiti> GetList(string filter)
            {
            List<Communiti> r = new List<Communiti>();
            var conn = DAL.GetConnection();
            conn.Open();
            r = conn.Query<Communiti>("select * from Communiti where IsDeleted=0 and  CommunitiName Like @filter", new { @filter = $"%{filter}%" }).ToList();
            conn.Close();
            return r;

        }
        public int Delete()
        {
            int r = 0;
            var conn = DAL.GetConnection();
            conn.Open();

            r=conn.Execute("Update Communiti set IsDeleted=1 where Id=@Id", new { @Id = this.Id});

            conn.Close();
            return r;
        }
        
    }
}