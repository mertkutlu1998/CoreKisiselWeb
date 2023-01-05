using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeatureDal:GenericRepository<Feature>,IFeatureDal // ,IFeatureDal kullanım amacı----> CRUD işlemleri haricinde farklı işlemler yapmak istersek diye kullanıyoruz.
    {
    }
}
