package com.example.aggiungicontatti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.os.Environment;
import android.provider.Settings;
import android.view.View;
import android.view.WindowManager;

import com.example.aggiungicontatti.databinding.ActivityMainBinding;
import com.google.android.material.snackbar.Snackbar;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.sql.Array;
import java.util.ArrayList;


public class MainActivity extends AppCompatActivity {
    private ActivityMainBinding binding;

    private static String _FILENAME = "rubrica.txt";
    private static File _FILE = new File(Environment.getExternalStorageDirectory() + "/" + File.separator + _FILENAME);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        getWindow().setSoftInputMode(WindowManager.LayoutParams.SOFT_INPUT_ADJUST_PAN);
        super.onCreate(savedInstanceState);
        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        askForPermissions();
        ArrayList<String> data = readFullFile();

        binding.salvaButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                saveContact();
            }
        });
    }

    @Override
    protected void onResume() {
        super.onResume();
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.R) {
            if (Environment.isExternalStorageManager()) {
                createFile();
            }
            readFullFile();
        }
    }

    public void askForPermissions() {
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.R) {
            if (!Environment.isExternalStorageManager()) {
                Intent intent = new Intent(Settings.ACTION_MANAGE_ALL_FILES_ACCESS_PERMISSION);
                startActivity(intent);
                return;
            }
            createFile();
        }
    }

    public void createFile() {
        if (!_FILE.exists()) {
            try {
                _FILE.createNewFile();
            } catch (Exception e) {
                Snackbar.make(findViewById(R.id.relativeLayout), "Il file non è stato creato!", Snackbar.LENGTH_LONG).show();
            }
        }
    }

    /* Return to the original page
    * */
    private void returnHome(){

    }

    private void saveContact() {

        String codice = binding.codiceInput.getText().toString();
        String nome = binding.nomeInput.getText().toString();
        String telefono = binding.telefonoInput.getText().toString();
        String note = binding.noteInput.getText().toString();

        //codice|nome|telefono|note
        
        if(codice == "" || nome == "" || telefono == "" || note == ""){
            Snackbar.make(findViewById(R.id.relativeLayout), "RIEMPIRE TUTTI I CAMPI!", Snackbar.LENGTH_LONG).show();
            return;
        }

        String whatToWrite = codice + "|" + nome + "|" + telefono + "|" + note + "|";

        try {
            FileOutputStream fos = openFileOutput(_FILENAME, Context.MODE_PRIVATE);
            PrintWriter writer = new PrintWriter(new OutputStreamWriter(fos));
            writer.println(whatToWrite);
            writer.close();
            fos.close();

            returnHome();
        } catch (Exception e) {
            Snackbar.make(findViewById(R.id.relativeLayout), "La scrittura del file è andata male!", Snackbar.LENGTH_LONG).show();
        }
    }


    private ArrayList<String> readFullFile() {
        ArrayList<String> data = new ArrayList<String>();

        try {
            FileInputStream fis = new FileInputStream(_FILE);
            BufferedReader reader = new BufferedReader(new InputStreamReader(fis));

            String line;
            while ((line = reader.readLine()) != null) {
                data.add(line);
            }

            reader.close();
            fis.close();

        } catch (Exception e) {
            Snackbar.make(findViewById(R.id.relativeLayout), "Errore nella lettura del file!", Snackbar.LENGTH_LONG).show();
        }

        return data;
    }

}