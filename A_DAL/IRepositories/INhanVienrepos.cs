using System;
using A_DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface INhanVienrepos
    {
        List<Nhanvien> GetAll();
        void Delete(Nhanvien nhanvien);
        Nhanvien Insert(Nhanvien nhanvien);
        void Update(Nhanvien nhanvien);
        List<Nhanvien> GetByID(String Found);
        List<Nhanvien> GetLstObjectByCV(String cv);
        Nhanvien DeleteByID(String id);
    }
}
