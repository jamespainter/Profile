package edu.weber.jamespainter.cs3270a3;



import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;
import java.util.Objects;
import java.util.Random;


/**
 * A simple {@link Fragment} subclass.
 */
public class TopFragment extends Fragment {

    private View rootView;
    //private Spinner spin_user;
    //private Button btn_Play;
    private TextView user_Select;
    private TextView tv_button;
    private TextView tv_phone;
    public TopFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        rootView = inflater.inflate(R.layout.fragment_top, container, false);
        Button  btn_Play = (Button) rootView.findViewById(R.id.btn_play);

        btn_Play.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Play();
            }
        });

       // AddToSpinner();
//        spin_user.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
//            @Override
//            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
//
//                Object item = parent.getItemAtPosition(position);
//                user_Select = item.toString();
//
//
//            }
//
//            @Override
//            public void onNothingSelected(AdapterView<?> parent) {
//
//            }
//        });


        return rootView;
    }



    public void Play()
    {
        tv_phone = (TextView) rootView.findViewById(R.id.tv_phone);
        tv_button = (TextView) rootView.findViewById(R.id.tv_button);
        user_Select = (TextView) rootView.findViewById(R.id.tv_user);
        Random random = new Random();
        int gen = random.nextInt(3)+1;
        if(gen == 1)
        {
            tv_phone.setText("Rock");
        }
        else if(gen == 2)
        {
            tv_phone.setText("Paper");
        }
        else
        {
            tv_phone.setText("Scissors");
        }
        int gen2 = random.nextInt(3)+1;
        if(gen2 == 1)
        {
            user_Select.setText("Rock");
        }
        else if(gen2 == 2)
        {
            user_Select.setText("Paper");
        }
        else
        {
            user_Select.setText("Scissors");
        }

        if(user_Select.getText().equals(tv_phone.getText().toString()))
        {
            tv_button.setText("NO ONE WINS");

        }
        else if(Objects.equals(user_Select.getText().toString(), "Rock") && Objects.equals(tv_phone.getText().toString(), "Scissors"))
        {
            tv_button.setText("You Win!");
            //Make a call to fragment bottom to increment score
            sendToMyScore();
        }
        else if(user_Select.getText().toString().equals("Paper") && Objects.equals(tv_phone.getText().toString(), "Rock")){
            tv_button.setText("You Win!");
            sendToMyScore();
        }
        else if(Objects.equals(user_Select.getText().toString(), "Scissors") && Objects.equals(tv_phone.getText().toString(), "Paper"))
        {
            tv_button.setText("You Win!");
            sendToMyScore();
        }
        else
        {
            tv_button.setText("The Phone Wins!");
            sendToPhoneScore();
        }

    }

    public void sendToPhoneScore()
    {
        MainActivity ma = (MainActivity) getActivity();
        ma.sendToFB();

    }

    public void sendToMyScore()
    {
        MainActivity ma = (MainActivity) getActivity();
        ma.sendToFB2();

    }
    public void clearResults(String message)
    { if(Objects.equals(message, "Yes"))
    {
        user_Select.setText("______");
        tv_button.setText("");
        tv_phone.setText("______");
    }



    }

//    public void AddToSpinner()
//    {
//        spin_user = (Spinner) rootView.findViewById(R.id.spin_user);
//        List<String> list = new ArrayList<String>();
//        list.add("_____");
//        list.add("Paper");
//        list.add("Rock");
//        list.add("Scissors");
//
//        ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(getContext(), R.layout.spinner_item, list);
//        dataAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
//        spin_user.setAdapter(dataAdapter);
//






}
