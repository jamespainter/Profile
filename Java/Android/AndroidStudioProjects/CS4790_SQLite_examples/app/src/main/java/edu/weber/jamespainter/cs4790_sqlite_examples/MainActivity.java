package edu.weber.jamespainter.cs4790_sqlite_examples;

import android.content.pm.PackageManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        if(savedInstanceState == null)
        {
            getSupportFragmentManager().beginTransaction()
                    .add(R.id.fragment_sqlite_frament, new SQLiteFrament(), "sf")
                    .add(R.id.fragment_bottom, new BottomFragment(), "bf")
                    .commit();
        }




    }


    public void reloadBottomFragment()
    {

        //BottomFragment bf = (BottomFragment) getSupportFragmentManager().findFragmentByTag("b");
        getSupportFragmentManager().beginTransaction().replace(R.id.fragment_bottom, new BottomFragment(), "bf").commit();


    }

    public int getVersion()
    {
        int versionCode = 1;

        try{
            versionCode =
                    getPackageManager().getPackageInfo(getPackageName(), PackageManager.GET_META_DATA).versionCode;
            Log.d("test", "in MainActivity Version = " + versionCode);
        }
        catch (Exception ex)
        {

        }
        return versionCode = 1;
    }

    public void populateSong(long id)
    {
        SQLiteFrament iFrag = (SQLiteFrament) getSupportFragmentManager().findFragmentByTag("sf");
        iFrag.populateSong(id);
    }

}
