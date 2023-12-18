using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepositories;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace A_DAL.Repositories
{
    public class NhanVienrepos : INhanVienrepos
    {
        public List<Nhanvien> GetAll()
        {
            using (Duan1QlBanquanaoContext db = new Duan1QlBanquanaoContext())
            {
                return db.Nhanviens.ToList();
            }
        }
        public Nhanvien Insert(Nhanvien nhanvien)
        {
            using (Duan1QlBanquanaoContext db = new Duan1QlBanquanaoContext())
            {
                db.Nhanviens.Add(nhanvien);
                db.SaveChanges();
                return nhanvien;
            }
        }
        public List<Nhanvien> GetByID(String Find)
        {
            using (Duan1QlBanquanaoContext db = new Duan1QlBanquanaoContext())
            {
                Find = Find.ToLower();
                List<Nhanvien> nvFound = db.Nhanviens.Where(nv => nv.MaNhanVien == Find||nv.TenNhanVien == Find||nv.TenDangNhap==Find).ToList();
                return nvFound;
            }
        }
        public Nhanvien DeleteByID(String id)
        {
            using (Duan1QlBanquanaoContext db = new Duan1QlBanquanaoContext())
            {
                var idFound = db.Nhanviens.Find(id);
                return idFound;
            }
        }
        public void Update(Nhanvien nhanvien)
        {
            using (Duan1QlBanquanaoContext db = new Duan1QlBanquanaoContext())
            {
                db.Nhanviens.Update(nhanvien);
                db.SaveChanges();
            }
        }
        public void Delete (Nhanvien nhanvien)
        {
            using (Duan1QlBanquanaoContext db = new Duan1QlBanquanaoContext())
            {
                db.Nhanviens.Attach(nhanvien);
                db.Nhanviens.Remove(nhanvien);
                db.SaveChanges() ;
            }
        }
        public List<Nhanvien> GetLstObjectByCV(String cv)
        {
            using (Duan1QlBanquanaoContext db = new Duan1QlBanquanaoContext())
            {
                List<Nhanvien> lstFound = db.Nhanviens.Where(nv=>nv.TenChucVu == cv ).ToList();
                return lstFound;
            }
        }
    }
}
