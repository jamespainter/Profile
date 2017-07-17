package edu.weber.jamespainter.mathlete;

import android.opengl.Visibility;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.LinearLayout;

public class MainActivity extends AppCompatActivity {
    View rootView;

    ///Login Fragment
    private LinearLayout l_lf;
    private LinearLayout l_mf;
    private LinearLayout l_nuf;
//    private LinearLayout l_clf;
//    private LinearLayout l_af;

    private Menu menu1;


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        //return super.onCreateOptionsMenu(menu);
        // getMenuInflater().inflate(R.menu.main_menu, menu);

        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.main_menu, menu);
        menu1 = menu;
        try{
            ///Do something here


        }
        catch (Exception e)
        {
            Log.d("OptionMenu", " onCreateOptionMenu Exception =  " + e.getMessage());
        }


        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        //return super.onOptionsItemSelected(item);
        int id = item.getItemId();
        try{
            if(id == R.id.item_new_user){

               ShowNewUserFragment();
               return true;
            }

        }
        catch (Exception e)
        {
            Log.d("OptionMenu", " onCreateOptionMenu Exception =  " + e.getMessage());
        }
        return false;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        if (savedInstanceState == null) {

            getSupportFragmentManager().beginTransaction().add(R.id.fragment_login, new Login(), "lf")
                    .add(R.id.fragment_module, new ModuleFragment(), "mf")
                    .add(R.id.fragment_new_user, new NewUserFragment(), "nuf")
                    .commit();

        }
        ///Map Layouts to Linear layout objects
        l_lf = (LinearLayout) findViewById(R.id.fragment_login);
        l_mf = (LinearLayout) findViewById(R.id.fragment_module);
        l_nuf = (LinearLayout) findViewById(R.id.fragment_new_user);
        ///Show the Login Fragment
        ShowLoginFragment();

    }

    public void ShowLoginFragment()
    {
        ///New User Fragment
        FragmentVisibility(l_nuf, false);
        ///Module Fragment
        FragmentVisibility(l_mf, false);
        ///Login Fragment
        FragmentVisibility(l_lf, true);
    }
    public void ShowNewUserFragment()
    {
        ///Login Fragment
        FragmentVisibility(l_lf, false);
        ///Module Fragment
        FragmentVisibility(l_mf, false);
        ///New User Fragment
        FragmentVisibility(l_nuf, true);

    }
    public void ShowModuleFragment()
    {
        ///Login Fragment
        FragmentVisibility(l_lf, false);
        ///New User Fragment
        FragmentVisibility(l_nuf, false);
        ///Module Fragment
        FragmentVisibility(l_mf, true);

    }
    ///Turn on/off fragment
    public void FragmentVisibility(LinearLayout frag, boolean visibility)
    {
        if(!visibility)
        {
            frag.setVisibility(View.GONE);
        }
        else
        {
            frag.setVisibility(View.VISIBLE);
        }
    }


}
