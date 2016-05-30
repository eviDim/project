using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AegeanProject
{
    public static class Helpers
    {
        public static bool IsFileValidImage(this HttpPostedFileBase file)
        {
            if (file == null)
                return true;
            if (file.ContentLength <= 0)
            {

                return false;

            }
            
            return file.ContentType == "image/png" || file.ContentType == "image/jpeg";
        }
    }
}