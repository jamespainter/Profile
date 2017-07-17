package edu.weber.jamespainter.cs3270a3;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        getSupportFragmentManager().beginTransaction().add(R.id.top_fragment, new TopFragment(), "TF").commit();
        getSupportFragmentManager().beginTransaction().add(R.id.bottom_fragment,new BottomFragment(),"BF").commit();
    }
    public void sendToFB()
    {
        BottomFragment bf =(BottomFragment) getSupportFragmentManager().findFragmentByTag("BF");
        bf.PhoneScore();

    }
    public void sendToFB2()
    {
        BottomFragment bf =(BottomFragment) getSupportFragmentManager().findFragmentByTag("BF");
        bf.myScore();
    }

    public void MessageFromFragment(String message)
    {
        BottomFragment bf = (BottomFragment) getSupportFragmentManager().findFragmentByTag("BF");
        bf.resetFinish(message);

        TopFragment topFragment = (TopFragment) getSupportFragmentManager().findFragmentByTag("TF");
        topFragment.clearResults(message);
    }




}
