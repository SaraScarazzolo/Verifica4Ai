
/**
 * Aggiungi qui una descrizione della classe Ricetta
 * 
 * @author (il tuo nome) 
 * @version (un numero di versione o una data)
 */
public class Ricetta
{
    // variabili d'istanza - sostituisci l'esempio che segue con il tuo
    private final int tempoPreparazione;
    private final String nomeRicetta;
    private int tempoCottura,nIngredienti=0;
    private String ingredienti[];
    private int qIngredienti[];
    private String preparazione,sitoRicetta;
 
    /**
     * Costruttore degli oggetti di classe  Ricetta
     */
    public Ricetta(int tempoPreparazione,String nomeRicetta)
    {
        // inizializza le variabili d'istanza
        this.tempoPreparazione=tempoPreparazione;
        this.nomeRicetta=nomeRicetta;
    }
    
    public Ricetta(int tempoPreparazione,String nomeRicetta,int tempoCottura, int nIngredienti,String ingredienti[],int qIngredienti[],String preparazione,String sitoRicetta)
    {
        // inizializza le variabili d'istanza
        this.tempoPreparazione=tempoPreparazione;
        this.nomeRicetta=nomeRicetta;
        this.tempoCottura=tempoCottura;
        this.nIngredienti=nIngredienti;
        this.ingredienti=ingredienti;
        this.qIngredienti=qIngredienti;
        this.preparazione=preparazione;
        this.sitoRicetta=sitoRicetta;
    }
    
    public Ricetta(int tempoPreparazione,String nomeRicetta,String ingredienti[],int qIngredienti[])
    {
        // inizializza le variabili d'istanza
        this.tempoPreparazione=tempoPreparazione;
        this.nomeRicetta=nomeRicetta;
        this.ingredienti=ingredienti;
        this.qIngredienti=qIngredienti;
    }
    /**
     * Un esempio di metodo - aggiungi i tuoi commenti
     * 
     * @param  y   un parametro d'esempio per un metodo
     * @return     la somma di x e y
     */
    public int getTempoPreparazione()
    {
        // metti qui il tuo codice
        return tempoPreparazione;
    }
    
    public String getNomeRicetta()
    {
        // metti qui il tuo codice
        return nomeRicetta;
    }
    
    public int getTempoCottura()
    {
        // metti qui il tuo codice
        return tempoCottura;
    }
    
     public String getPreparazione()
    {
        // metti qui il tuo codice
        return preparazione;
    }
    
    public String getSitoRicetta()
    {
        // metti qui il tuo codice
        return sitoRicetta;
    }
    
    public void setPreparazione()
    {
        
    }
    
    public void aggiungiIngrediente(String ing,int q)
    {
      ingredienti[nIngredienti] = ing;
      qIngredienti[nIngredienti] = q;
      nIngredienti++;
    }
    public String toString()
    {
        String s="";
        s+=nomeRicetta+"\n";
        for (int i=0; i<nIngredienti; i++)
        {
            s+="\n"+"ingrediente: "+ingredienti[i]+" quantità: "+qIngredienti[i];
        }
    
        return s;
    }
}
