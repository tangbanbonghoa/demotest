using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Repositories;
using A_DAL.IRepositories;
using A_DAL.Models;

namespace B_BUS.IServices
{
    public interface INhanVienServices
    {
        List<Nhanvien> GetAll();
        void Delete(Nhanvien nhanvien);
        Nhanvien Insert(Nhanvien nhanvien);
        void Update(Nhanvien nhanvien);
        List<Nhanvien> GetByID(String Found);
        List<Nhanvien> GetLstObjectByCV(string cv);

    }
}
