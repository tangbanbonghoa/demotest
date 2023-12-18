using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_BUS.IServices;
using A_DAL.Repositories;
using A_DAL.IRepositories;
using A_DAL.Models;

namespace B_BUS.Services
{
    public class NhanVienServices
    {
        static INhanVienrepos repos;
        static NhanVienServices()
        {
            repos = new NhanVienrepos(); 
        }
        public static List<Nhanvien> GetAll()
        {
            return repos.GetAll();
        }
        public static List<Nhanvien> GetByID(String Find)
        {
            return repos.GetByID(Find);
        }
        public static Nhanvien Insert(Nhanvien nhanvien)
        {
            return repos.Insert(nhanvien);
        }
        public static void Update (Nhanvien nhanvien)
        {
            repos.Update(nhanvien); 
        }
        public static void Delete(Nhanvien nhanvien)
        {
            repos.Delete(nhanvien);
        }
        public static List<Nhanvien> GetLstObjectByCV(string cv)
        {
            return  repos.GetLstObjectByCV(cv);
        }
        public static Nhanvien DeleteByID(String id)
        {
            return repos.DeleteByID(id);
        }

    }
}
