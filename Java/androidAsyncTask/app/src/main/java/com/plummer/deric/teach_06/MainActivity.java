package com.plummer.deric.teach_06;

import android.content.Context;
import android.content.ContextWrapper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.ProgressBar;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    private List<String> myList;
    private ArrayAdapter<String> _aa;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        myList = new ArrayList<>();
        _aa = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, myList);

    }

    /*********************************
     * ON Create CLICK
     **********************************/

    protected void onClickCreate(View view) {

        CreateFileTask createFileTask = new CreateFileTask(
                this, "numbers.txt", (ProgressBar) findViewById(R.id.progressBar));
        createFileTask.execute();


    }

    /*********************************
    * ON LOAD CLICK
    **********************************/
    protected void onClickLoad(View view) {
        LoadFileTask loadFileTask = new LoadFileTask(this, "numbers.txt", _aa, (ProgressBar) findViewById(R.id.progressBar));
        loadFileTask.execute();

        ListView lv = (ListView) findViewById(R.id.listView);
        lv.setAdapter(_aa);
        }

    /*********************************
     * ON CLEAR CLICK
     **********************************/
    protected void onClickClear(View view) {
        if (_aa != null) {
            _aa.clear();
            ListView lv = (ListView) findViewById(R.id.listView);
            lv.setAdapter(_aa);
        }
    }
}

