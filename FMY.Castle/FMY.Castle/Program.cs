/*
 *出处：http://terrylee.cnblogs.com
 */
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMY.Castle.Log;
using Castle.MicroKernel.Registration;
/*
* 服务是一个个的接口，接口约定了服务，从而使随意替换服务的实现对使用接口服务的代码没有任何的影响。
* 组件是一个可重用的程序单元，它实现了某个接口，并仅仅只实现了这一个良好的接口。
*/
namespace FMY.Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlPath = AppDomain.CurrentDomain.BaseDirectory + "Config\\CastleConfig.xml";
            //建立容器
            IWindsorContainer container = new WindsorContainer(new XmlInterpreter(xmlPath));

            #region antique

            //加入组件
            //container.AddComponent("txtLog",
            //    typeof(ILog), typeof(TextFileLog));
            //container.AddComponent("format",
            //    typeof(ILogFormatter), typeof(TextFormatter)); 
            //获取组件
            //ILog log = (ILog)container["txtLog"];

            #endregion
            
            //加入组件
            container.Register(Component.For(typeof(ILog)).ImplementedBy(typeof(TextFileLog)).Named("txtLog"));
            container.Register(Component.For(typeof(ILogFormatter)).ImplementedBy(typeof(TextFormatter)).Named("format"));

            //获取组件
            ILog log = container.Resolve<ILog>("TxtLog");

            //使用组件
            log.Write("First Castle IOC Demo");
            Console.ReadLine();
        }
    }

}
