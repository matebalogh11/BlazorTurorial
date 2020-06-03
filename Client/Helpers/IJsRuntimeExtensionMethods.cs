using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerTutorialProject.Client.Helpers
{
    public static class IJsRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm( this IJSRuntime js, string message )
        {
            return await js.InvokeAsync<bool>("confirm", message);
        }
    }
}
