﻿#region License
// MIT License
// 
// Copyright (c) 2018 
// Marcus Technical Services, Inc.
// http://www.marcusts.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

namespace SharedForms.Common.Utils
{
   using System;
   using Autofac;
   using Navigation;
   using SharedGlobals.Container;
   using Xamarin.Forms.Xaml;

   /// <summary>
   /// https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/markup-extensions/creating
   /// </summary>
   public class StateMachineAccessorExtension : IMarkupExtension<IStateMachineBase>
   {
      public IStateMachineBase ProvideValue(IServiceProvider serviceProvider)
      {
         return AppContainer.GlobalVariableContainer.Resolve<IStateMachineBase>();
      }

      object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
      {
         return ProvideValue(serviceProvider);
      }
   }
}