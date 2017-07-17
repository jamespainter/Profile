package edu.weber.jamespainter.listview_example;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;

import static edu.weber.jamespainter.listview_example.R.id.parent;

public class MainActivity extends AppCompatActivity {

    ListView lv_item_list;
    Button btn_Add;
    EditText et_Item_To_Add;
    ArrayAdapter<String> adapter;
    ArrayList<String> list;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        et_Item_To_Add = (EditText) findViewById(R.id.et_item_to_add);
        list = new ArrayList<>();
        lv_item_list = (ListView) findViewById(R.id.lv_item_list);
        adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, list);
        lv_item_list.setAdapter(adapter);

//        lv_item_list.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
//            @Override
//            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
//                return false;
//            }
//        });

        lv_item_list.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {

                TextView v = (TextView) view;
                 Toast.makeText(getApplicationContext(), "Long pressed on " + v.getText().toString(), Toast.LENGTH_SHORT);
                return false;

            }
        });


    btn_Add = (Button) findViewById(R.id.btn_add);
        btn_Add.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                list.add(et_Item_To_Add.getText().toString());
                adapter.notifyDataSetChanged();
                Log.d("test", "list has " + list.size() + " elements");
            }
        });

    }
}
