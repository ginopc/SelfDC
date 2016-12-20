# Self DataColletor (SelfDC): data collection for shops
A complete application for WinCE Portable Digital Assistant (PdA).
Follows some release note.

## Version 0.0.9a1 (2015.06.04)
Important bug correction

## Version 0.0.9 (2015.05.19)
Log Filename now is one per day

## Version 0.0.8 (2014.12.12)
(build 21019)
Modificato il formato di esportazione dell'inventario. La QTA è formattata con 3 decimali senza virgola (#0000)


## Version 0.0.7 (2014.12.05)
Eliminate da Utils le funzioni di esportazione file Ordini e etichette perchè non più usate.
Correzione bug


## Version 0.0.6 (2014.11.20)
(build 23637)
Correzione bug su esportazione Inventario
Correzione bug OrderForm, LabelForm, InventoryForm: tutti i campi abilitati su modifica riga, dopo nuovo inserimento non terminato.

## Version 0.0.5a3 (2014.11.18)
(build 32648)
Risolto problema su inserimento dato QTA con formato sbagliato (ISSUE 3 su GitHub).
Inserito caricamento logo da file immagine "app.png"

## Version 0.0.5a2 (17.11.2014)
(build 29805)
Correzione problema Datalogic su assegnazione Evento OnSCan di maschere differenti
Forzata validazione del campo QTA anche dietro pressione del tasto ENTER.
Aggiunta selezione del testo nel campo QTA durante l'editing del campo sulle finestre Ordini, Etichette e Inventario.

## Version 0.0.5 (2014.11.14)
(build 31841)
Inserita versione automatica nella maschera MainForm
Corretta dicitura su esportazione etichette "Esporta Ordine".
Corretta dicitura su esportazione ordine "Esporta Etichette".
Cambiato layout grafico sulla maschera del menu principale. Ora viene riportato il logo, il numero di versione e le icone sono colorate e disposte automaticamente in base alla risoluzione dello schermo.
Aggiunta maschera di collezionamento dati per Inventario.
Aggiunti controlli di formattazione delle quantità durante l'inserimento dei dati o la scansione dei codici.

## Version 0.0.4
Nuova maschera LabelsForm per il collezionamento dei codici per stampare le etichette.
Inserito form MenuForm con stile mobile per la selezione delle maschere

## Version 0.0.3.2
Il defaul nell'inserimento di un codice manuale è "codice interno". Precedentemente era Codice EAN.


## Version 0.0.3
Inserito file di configurazione. La lettura dei codici interni da listino prevede il carattere '$' iniziale


## Version 0.0.2
Prima versione stabile del programma.
TODO: 
 - inserire file di configurazione
 - implementare persistenza dei dati per evitare la perdita dell'ordine 
   parziale se si chiude il programma o lo stesso va in errore

