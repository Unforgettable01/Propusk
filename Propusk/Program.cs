using Database.Implements;
using Logic.Interfaces;
using Logic.Logics;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace Propusk
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<IClientStorage,ClientStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<ClientLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IWorkerStorage, WorkerStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<WorkerLogic>(new HierarchicalLifetimeManager());


            return currentContainer;
        }
    }
}

