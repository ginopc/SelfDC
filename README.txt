Self DataColletor (SelfDC)
==========================

##> Versione 0.0.7
Eliminate da Utils le funzioni di esportazione file Ordini e etichette perchè non più usate.
correzione bug


##> Versione 0.0.6
(build 23637 del 02.12.2014)
Correzione bug su esportazione Inventario
Correzione bug OrderForm, LabelForm, InventoryForm: tutti i campi abilitati su modifica riga, dopo nuovo inserimento non terminato.

##> Versione 0.0.5
(build 31841 del 20.11.2014)
Inserita versione automatica nella maschera MainForm

(build 32648 del 18.11.2014)
Risolto problema su inserimento dato QTA con formato sbagliato (ISSUE 3 su GitHub).
Inserito caricamento logo da file immagine "app.png"

(build 29821 del 17.11.2014)
Forzata validazione del campo QTA anche dietro pressione del tasto ENTER.
Aggiunta selezione del testo nel campo QTA durante l'editing del campo sulle finestre Ordini, Etichette e Inventario.

(build 29805 del 17.11.2014)
Correzione problema Datalogic su assegnazione Evento OnSCan di maschere differenti

(build 28512 del 14.11.2014)
Corretta dicitura su esportazione etichette "Esporta Ordine".
Corretta dicitura su esportazione ordine "Esporta Etichette".
Cambiato layout grafico sulla maschera del menu principale. Ora viene riportato il logo, il numero di versione e le icone sono colorate e disposte automaticamente in base alla risoluzione dello schermo.
Aggiunta maschera di collezionamento dati per Inventario.
Aggiunti controlli di formattazione delle quantità durante l'inserimento dei dati o la scansione dei codici.


##> Versione 0.0.4
Nuova maschera LabelsForm per il collezionamento dei codici per stampare le etichette.
Inserito form MenuForm con stile mobile per la selezione delle maschere

##> Versione 0.0.3.2
Il defaul nell'inserimento di un codice manuale è "codice interno". Precedentemente era Codice EAN.


##> Versione 0.0.3
Inserito file di configurazione. La lettura dei codici interni da listino prevede il carattere '$' iniziale


##> Vesione 0.0.2
Prima versione stabile del programma.
TODO: 
 - inserire file di configurazione
 - implementare persistenza dei dati per evitare la perdita dell'ordine 
   parziale se si chiude il programma o lo stesso va in errore

