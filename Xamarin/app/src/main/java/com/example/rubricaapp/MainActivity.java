package com.example.rubricaapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.Environment;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    List<String> rubrica = new ArrayList<>();
    ArrayAdapter<String> arrayAdapter;
    ListView listView;
    private String fileName = "rubrica.txt";
    private String filePath = "C:\\Users\\stefano.brembati\\Downloads\\prova";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        arrayAdapter = new ArrayAdapter<>(this, R.layout.list_view_layout, rubrica);
        listView = findViewById(R.id.id_list_view);

        listView.setAdapter(arrayAdapter);

        readFile();
    }

    public void aggiungiElemento(View view) {
        Intent intent = new Intent(this, ModifyElement.class);
        startActivity(intent);
    }

    public void modificaElemento(View view) {

    }

    public void readFile() {

        StringBuilder builder = new StringBuilder();

        File newFile = new File(filePath + fileName);

        try {
            newFile.createNewFile();//creates a file otherwise do nothing
        } catch (IOException e) {
            e.printStackTrace();
            Toast.makeText(this, "Errore permessi in scrittura e/o lettura!", Toast.LENGTH_LONG).show();
            return;
        }

        BufferedReader bufferedReader = null;

        try {
            bufferedReader = new BufferedReader(new FileReader(newFile));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
            Toast.makeText(this, "Errore lettura file!", Toast.LENGTH_LONG).show();
            return;
        }
        String row = "";

        try {

            bufferedReader.close();
        } catch (IOException e) {
            e.printStackTrace();
            Toast.makeText(this, "Errore nella chiusura del file!", Toast.LENGTH_LONG).show();
            return;
        }
    }
}