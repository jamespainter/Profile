package edu.weber.jamespainter.week5examples;

import android.net.Uri;
import android.support.v7.app.ActionBar;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.Toolbar;

//import com.google.android.gms.appindexing.Action;
//import com.google.android.gms.appindexing.AppIndex;
//import com.google.android.gms.appindexing.Thing;
//import com.google.android.gms.common.api.GoogleApiClient;

public class MainActivity extends AppCompatActivity {

    /**
     * ATTENTION: This was auto-generated to implement the App Indexing API.
     * See https://g.co/AppIndexing/AndroidStudio for more information.
     */

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {

        getMenuInflater().inflate(R.menu.menu, menu);

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
//
        int id = item.getItemId();
        if(id == R.id.action_settings){
            return true;
        }
        if(id == R.id.action_ClearFields){
            BottomFragment bottomFragment = (BottomFragment) getSupportFragmentManager().findFragmentByTag("bf");
            if(bottomFragment != null)
                bottomFragment.clearfields();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);





        getSupportFragmentManager().beginTransaction().replace(R.id.Main_Fragment, new MainFragment(), "mf").commit();
        getSupportFragmentManager().beginTransaction().replace(R.id.bottom_Fragment, new BottomFragment(), "bf").commit();
        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.

    }


    @Override
    protected void onResume() {
        super.onResume();
        Log.d("test", "MainActivity onResume");
    }

    @Override
    protected void onPause() {
        super.onPause();
        Log.d("test", "MainActivity onPause");
    }

    /**
     * ATTENTION: This was auto-generated to implement the App Indexing API.
     * See https://g.co/AppIndexing/AndroidStudio for more information.
     */


    @Override
    public void onStart() {
        super.onStart();

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.

    }

    @Override
    public void onStop() {
        super.onStop();

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.

    }
}
