using Android.App;
using Android.OS;
using Android.Views;

namespace DrawerExample
{
    public class Third : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.Third, container, false);
        }
    }
}