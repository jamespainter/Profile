package edu.weber.jamespainter.cs3270_example_fragment2;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        Log.d("log_OnCreate", "In the On Create Override");
        setContentView(R.layout.activity_main);

        getSupportFragmentManager().beginTransaction().add(R.id.fragment_a, new FragmentA(), "btn_frag_A").commit();
        getSupportFragmentManager().beginTransaction().add(R.id.fragment_c, new FragmentC(), "tvc").commit();

    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        Log.d("log_OnDestroy", "In the on Destroy Override");
    }

    @Override
    protected void onStart() {
        super.onStart();
        Log.d("log", "In the On Start Override");
    }

    @Override
    protected void onStop() {
        super.onStop();
        Log.d("log", "In the On Stop Override");
    }

    @Override
    protected void onPause() {
        super.onPause();
        Log.d("log", "In the On Pause Override");
    }

    @Override
    protected void onResume() {
        super.onResume();
        Log.d("log", "In the On Resume event Override");
    }

    public void SendToC(String message)
    {

        FragmentC fc = (FragmentC) getSupportFragmentManager().findFragmentByTag("tvc");
        fc.setMessage(message);

    }


}
