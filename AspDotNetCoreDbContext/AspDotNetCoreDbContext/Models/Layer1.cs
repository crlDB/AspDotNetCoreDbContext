using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace AspDotNetCoreDbContext
{
    public interface ILayer1
    {
        ToClient1 CreateRec();

    }
    public class Layer1 : ILayer1
    {
        private DbAspNetCoreCtx _dbAspNetCoreCtx;
        private IServiceProvider _serviceProvider;

        public Layer1(
            DbAspNetCoreCtx dbAspNetCoreCtx,
            IServiceProvider serviceProvider)
        {
            _dbAspNetCoreCtx = dbAspNetCoreCtx;
            _serviceProvider = serviceProvider;
        }

        public ToClient1 CreateRec()
        {

            ToClient1 toCli = new ToClient1();

            CreateRecTask();
            return toCli;

            try
            {
                var _dbCfg = _dbAspNetCoreCtx;
                //using (var _dbCfg = _dbAspNetCoreCtx)
                //{

                Table1 rec = new Table1();
                rec.Num1 = (int)DateTime.Now.Ticks;
                rec.String1 = rec.Num1.ToString();

                _dbCfg.Add(rec);
                try
                {
                    _dbCfg.SaveChanges();
                }
                catch (Exception ex)
                {
                }

                try
                {
                    toCli.CountRec = _dbCfg.Table1.Count();
                }
                catch (Exception ex)
                {
                    toCli.CountRec = 0;
                }

                //}


                toCli.CtxCtor = Helper.CtxConstructor;

            }
            catch (Exception ex)
            {
            }

            return toCli;
        }

        public void CreateRecTask()
        {
            {
                try
                {
                    var cancelTask = new CancellationTokenSource();
                    var task = new Task(new Action(TaskScript), cancelTask.Token, TaskCreationOptions.None);
                    task.Start();
                }
                catch (Exception ex)
                {
                }


            }

        }

        private void TaskScript()
        {
            try
            {
                var scope = _serviceProvider.CreateScope();
                var dbCfg = scope.ServiceProvider.GetService<DbAspNetCoreCtx>(); //  scoped
                //var dbCfg = _serviceProvider.GetService<DbAspNetCoreCtx>(); //  scoped



                Table1 rec = new Table1();
                rec.Num1 = 100;
                rec.String1 = "100";


                dbCfg.Add(rec);
                try
                {
                    dbCfg.SaveChanges();
                }
                catch (Exception ex)
                {
                }

            }
            catch (Exception erx)
            {
            }
        }
    }
}
