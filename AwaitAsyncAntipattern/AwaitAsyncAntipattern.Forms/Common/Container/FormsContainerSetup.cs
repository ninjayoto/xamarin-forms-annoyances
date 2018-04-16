﻿namespace AwaitAsyncAntipattern.Forms.Common.Container
{
   #region Imports

   using Autofac;
   using SharedGlobals.Container;

   #endregion

   public class FormsContainerSetup : ContainerSetup
   {
      //------------------------------------------------------------------------------------------
      protected override void RegisterDependencies(ContainerBuilder containerBuilder)
      {
         base.RegisterDependencies(containerBuilder);
      }
   }
}
