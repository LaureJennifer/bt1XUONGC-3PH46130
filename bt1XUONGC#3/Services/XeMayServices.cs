using bt1XUONGC_3.DomainClass;
using bt1XUONGC_3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1XUONGC_3.Services
{
    
    internal class XeMayServices
    {
        XemayRepository _xeMayRepo;
        public XeMayServices()
        {
            _xeMayRepo = new XemayRepository();
        }
        public List<LoaiXm> GetloaiXe()
        {

            return _xeMayRepo.GetLoaiXe();
        }
        public List<XeMay> GetAll(string textSearch)
        {
            return _xeMayRepo.GetAll(textSearch);
        }
        public bool Add(XeMay xemay)
        {
            return _xeMayRepo.Add(xemay);
        }

        public bool Delete(Guid id) 
        {
            return _xeMayRepo.Delete(id);
        }
        public bool CheckGiaNhap(string GiaNhap)
        {
            return _xeMayRepo.ChecktypeGia(GiaNhap);
        }
        public bool CheckvalueGia(decimal GiaNhap)
        {
            return _xeMayRepo.checkValueGia(GiaNhap);
        }
        public bool CheckTenXe(string TenXe)
        {
            return _xeMayRepo.CheckTenXe(TenXe);
        }

        
    }
}
