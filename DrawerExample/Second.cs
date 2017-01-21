using Android.App;
using Android.OS;
using Android.Views;

namespace DrawerExample
{
    public class Second : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.Second, container, false);
        }
    }
}