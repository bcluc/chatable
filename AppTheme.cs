using Microsoft.JSInterop;

namespace Chatable
{
    public class AppTheme
    {
        private readonly IJSRuntime js;

        public AppTheme(IJSRuntime js)
        {
            this.js = js;
        }

        private bool isLeftMode = false;

        public bool IsLeftMode
        {
            get => isLeftMode;
            set
            {
                isLeftMode = value;
                js.InvokeVoidAsync("setLeftMode", value);
            }
        }
    }
}
