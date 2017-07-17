package edu.weber.jamespainter.cs3270a2;


import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.FrameLayout;


public class MainActivity extends AppCompatActivity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {




        Button btn_FragmentB;
        Button btn_FragmentC;
        Button btn_FragmentD;
        Button btn_Switch34;

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        btn_FragmentB = (Button) findViewById(R.id.btn_Load_Frag_2);
        btn_FragmentC = (Button) findViewById(R.id.btn_Load_Frag_3);
        btn_FragmentD = (Button) findViewById(R.id.btn_Load_Frag_4);
        btn_Switch34 = (Button) findViewById(R.id.btn_Switch_3_4);

        getSupportFragmentManager().beginTransaction().add(R.id.fragmentContainer1, new FragmentA(), "FA").commit();

        btn_FragmentB.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getSupportFragmentManager().beginTransaction().replace(R.id.fragmentContainer2, new FragmentB(), "FB").commit();
            }
        });

        btn_FragmentC.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                getSupportFragmentManager().beginTransaction().replace(R.id.fragmentContainer3, new FragmentC(), "FC").commit();
            }
        });

        btn_FragmentD.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                getSupportFragmentManager().beginTransaction().replace(R.id.fragmentContainer4, new FragmentD(), "FD").commit();

            }
        });

        btn_Switch34.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                getSupportFragmentManager().beginTransaction().replace(R.id.fragmentContainer4, new FragmentC(), "FD").commit();

                getSupportFragmentManager().beginTransaction().replace(R.id.fragmentContainer3, new FragmentD(), "FC").commit();
            }
        });




    }
}
