using Android.App;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;

namespace DrawerExample
{
    [Activity(Label = "DrawerExample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        ListView drawerListView;
        DrawerLayout drawerLayout;
        ActionBarDrawerToggle drawerToggle;

        Fragment[] fragments = new Fragment[] { new First(), new Second(), new Third(), new Fourth(), new Fifth() };
        string[] titles = new string[] { "First Item", "Second Item", "Third Item", "Fourth Item", "Fifth Item" };

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);            
            SetContentView(Resource.Layout.Main);

            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLauout);

            drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, Resource.String.DrawerOpenDescription, Resource.String.DrawerCloseDescription);

            drawerLayout.AddDrawerListener(drawerToggle);

            ActionBar.SetDisplayHomeAsUpEnabled(true);



            drawerListView = FindViewById<ListView>(Resource.Id.listView);
            drawerListView.Adapter = new ArrayAdapter<string>(this, Resource.Layout.ListViewMenuRow, Resource.Id.menuRowTextView, titles);
            drawerListView.ItemClick += (s, e) => OnMenuClick(e.Position);
            drawerListView.SetItemChecked(0, true);
            OnMenuClick(0);
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            drawerToggle.SyncState();
            base.OnPostCreate(savedInstanceState);
        }

        private void OnMenuClick(int position)
        {
            base.FragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, fragments[position]).Commit();

            this.Title = titles[position];

            drawerLayout.CloseDrawer(drawerListView);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (drawerToggle.OnOptionsItemSelected(item))
                return true;

            switch (item.ItemId)
            {
                default:
                    break;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}

