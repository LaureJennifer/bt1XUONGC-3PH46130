using bt1XUONGC_3.Context;
using bt1XUONGC_3.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace bt1XUONGC_3.Repositories
{
    internal class XemayRepository
    {
        DBContext _dbContext;

        public XemayRepository()
        {
            _dbContext = new DBContext();
        }

        //Get All
        public List<LoaiXm> GetLoaiXe()
        {
            return _dbContext.LoaiXms.ToList();
        }

        public List<XeMay> GetAll(string textSearch)
        {
            if (string.IsNullOrWhiteSpace(textSearch))
            {
                var listObj = _dbContext.XeMays.ToList();

                return listObj;
            }
            else
            {
                var listObj = _dbContext.XeMays.Where(x => x.Ten.Contains(textSearch)).ToList();

                return listObj;
            }


        }
        //Get By Id
        public XeMay? GetById(Guid id)
        {
            var obj = _dbContext.XeMays.FirstOrDefault(x => x.Id == id);
            return obj;
        }
        //Add
        public bool Add(XeMay xeMay)
        {
            try
            {
                xeMay.Id = Guid.NewGuid();
                _dbContext.Add(xeMay);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        
        
        //Delete
        public bool Delete(Guid id)
        {
            try
            {
                var obj = GetById(id);
                if (obj == null)
                {
                    return false;
                }

                _dbContext.Remove(obj);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CheckDuplicateMaXe(string maXeMay)
        {
            var obj = _dbContext.XeMays.FirstOrDefault(x => x.Ma == maXeMay );
            if (obj == null)
            {
                return false;
            }
            return true;
        }
        public bool ChecktypeGia(string GiaNhap)
        {
            
            try
            {
                if (Convert.ToDecimal(GiaNhap) != null)
                {
                    return true;
                }
                return true;
                
            }
            catch (Exception)
            {
                return false;
            } 
        }
        public bool checkValueGia(decimal giaNhap)
        {
            if (giaNhap > 0)
            {
                return true;
            }
            return false;
        }
        public bool CheckTenXe(string TenXeMay)
        {
            var obj = _dbContext.XeMays.Any(x => x.Ten.Contains(TenXeMay.ToLower()));
            if (obj == false)
            {
                return false;
            }
            return true;
        }
    }
}
