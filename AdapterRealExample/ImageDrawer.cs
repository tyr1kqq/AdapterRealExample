using AdapterRealExample.Devies;

namespace AdapterRealExample
{
    class ImageDrawer
    {
        public void DrawWith (IPrinter printer)
        {
            printer.Print();
        }
    }
}
