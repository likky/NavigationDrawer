using Android.App;
using Android.OS;
using Android.Views;

namespace DrawerExample
{
    public class Fourth : Fragment
    {       
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.Fourth, container, false);
        }
    }
}