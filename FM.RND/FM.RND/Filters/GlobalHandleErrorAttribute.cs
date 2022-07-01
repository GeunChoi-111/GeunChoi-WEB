using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FM.RND.Filters
{
    public class GlobalHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //로그 추가 예정

            base.OnException(filterContext);
        }
    }
}