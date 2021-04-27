using System;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation metotName)
        {
        }

        protected virtual void OnAfter(IInvocation metotName)
        {
        }

        protected virtual void OnException(IInvocation metotName, System.Exception e)
        {
        }

        protected virtual void OnSuccess(IInvocation metotName)
        {
        }

        public override void Intercept(IInvocation metotName)
        {
            var isSuccess = true;
            OnBefore(metotName);
            try
            {
                metotName.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(metotName, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(metotName);
                }
            }

            OnAfter(metotName);
        }
    }
}