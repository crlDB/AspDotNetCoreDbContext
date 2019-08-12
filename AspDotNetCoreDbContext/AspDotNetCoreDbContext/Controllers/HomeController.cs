using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;


namespace AspDotNetCoreDbContext.Controllers
{
    public class HomeController : Controller
    {
        private IServiceProvider _serviceProvider;

        public HomeController(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatRec1([FromBody]ToServer1 toSrv)
        {
            ToClient1 toCli = new ToClient1();

            using (var _dbCfg = _serviceProvider.GetService<DbAspNetCoreCtx>())
            {
                Table1 rec = new Table1();
                rec.Num1 = 100;
                rec.String1 = "100";


                _dbCfg.Add(rec);
                try
                {
                    _dbCfg.SaveChanges();
                }
                catch (Exception)
                {
                }

                try
                {
                    toCli.CountRec = _dbCfg.Table1.Count();
                }
                catch (Exception)
                {
                    toCli.CountRec = 0;
                }


            }


            // to client
            toCli.CtxCtor = Helper.CtxConstructor;

            // return data
            return Json(toCli);
        }

        [HttpPost]
        public IActionResult CreatRec2([FromBody]ToServer1 toSrv)
        {

            ILayer1 LA1 = _serviceProvider.GetService<ILayer1>();
            ToClient1 toCli = LA1.CreateRec();

            ILayer1 LA1a = _serviceProvider.GetService<ILayer1>();
            toCli = LA1a.CreateRec();

            ILayer1 LA1b = _serviceProvider.GetService<ILayer1>();
            toCli = LA1b.CreateRec();

            // to client
            var _dbCfg = _serviceProvider.GetService<DbAspNetCoreCtx>();

            try
            {
                toCli.CountRec = _dbCfg.Table1.Count();
            }
            catch (Exception)
            {
                toCli.CountRec = 0;
            }




            toCli.CtxCtor = Helper.CtxConstructor;

            return Json(toCli);
        }

    }

}
