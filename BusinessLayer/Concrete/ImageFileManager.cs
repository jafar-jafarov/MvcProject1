using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _iimagefile;

        public ImageFileManager(IImageFileDal iimagefile)
        {
            _iimagefile = iimagefile;
        }

        public List<ImageFile> GetList()
        {
            return _iimagefile.List();
        }
    }
}
