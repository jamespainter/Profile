package edu.weber.jamespainter.week_8_rest_api;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
//import com.google.gson.Gson;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

       // Gson gson = new Gson();

        getSupportFragmentManager().beginTransaction().add(R.id.Canvas_Fragment, new CanvasObjectFragment(), "cof").commit();

    }
}
