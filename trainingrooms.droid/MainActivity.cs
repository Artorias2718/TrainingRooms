using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using TrainingRooms;

namespace trainingrooms.droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var repo = new RoomRepository();
            var rooms = repo.GetRooms();

            var adapter = new ArrayAdapter<TrainingRoom>(this, Resource.Layout.RoomListItem, rooms.ToArray());
            this.ListAdapter = adapter;
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            var intent = new Intent(this, typeof(TrainingRoomDetailActivity));
            var selectedItem = ((ArrayAdapter <TrainingRoom>)ListAdapter).GetItem(position);
            intent.PutExtra("roomId", selectedItem.Id);
            StartActivity(intent);
        }
    }
}

