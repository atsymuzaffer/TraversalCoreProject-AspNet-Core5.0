using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TAdd(About t)
        {
            _aboutDal.Insert(t);

        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);

        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }

        public List<About> TGetList()
        {
            throw new NotImplementedException();
        }

        //buraya gelince about t de hata olabilir kontrol et
       // public List<About> TGetList(About t)
        //{
         //   return _aboutDal.GetList();
        //}

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
