using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        Writer GetById(int id);
        void WriterUpdate(Writer writer);
        void WriterAdd(Writer writer);
        void WriterDelete(Writer writer);


    }
}
