using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Project__mittegna_
{
    public partial class AuthorBook : Form
    {
        LTSDataContext db = new LTSDataContext(); //Lägger till ett objekt som anropar database.

        public AuthorBook()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AuthorDGV.DataSource = AuthorBS; //DataGridViewens datasource i Author är samma som binding source för Author.
            AuthorBS.DataSource = from allAuthors in db.Authors //Vilken tabell som ska visas och hur den ska ordnas.
                                  orderby allAuthors.Author_Name // -||-
                                  select allAuthors; // -||-

            BooksAuthorNameCbx.DataSource = from cbxData in db.Authors //Visar hur comboboxen i Books ska sorteras efter Author Name.
                                            orderby cbxData.Author_Name //-||-
                                            select cbxData; //-||-

            BooksAuthorNameCbx.DisplayMember = "Author_Name"; //Vad för namn som ska visas
            BooksAuthorNameCbx.ValueMember = "Author_ID"; // Vilket ID det motsvarar.

            BooksDGV.DataSource = BooksBS; //DataGridViewens datasource i Books är samma som Binding source för Books.
            BooksBS.DataSource = from allBooks in db.Books //Vilken tabell som ska visas och hur den ska visas.
                                 orderby allBooks.Book_Name// -||-
                                 select allBooks; // -||-

            BooksDGV.Columns[BooksDGV.Columns.Count - 1].Visible = false; //Att "Author1" columnen inte ska visas. 
        }
        #region Authors
        private void AuthorSaveBtn_Click(object sender, EventArgs e)
        {
            Author a = new Author(); //Ett nytt tomt objekt av klassen Author.

            try //pröva detta!
            {
                a.Author_Name = AuthorNameTbx.Text; //Att Author Name är samma sak som skrivs i textrutan under "Author Name".
                a.Age = int.Parse(AuthorAgeTbx.Text); //Att Age är samma sak som det som skrivs i textrutan under "Age".
                a.Born_In = AuthorHomeTownTbx.Text; //Att Born_In är samma sak som det som skrivs i textrutan under "Hometown".
                a.Genre = AuthorGenreTbx.Text; //Att Genre är samma sak som det som skrivs i textrutan under "Genre"
                a.Startyear = AuthorStartYearTbx.Text; //Att Startyear är samma sak som det som skrivs i textrutan under "Startyear"

                db.Authors.InsertOnSubmit(a); //Att det ska sparas när man trycker på knappen i objektet A.
                db.SubmitChanges(); //Ändra.

                AuthorNameTbx.Clear(); //Att när man skrivit en profil ska alla textrutor clearas.
                AuthorAgeTbx.Clear(); // -||-
                AuthorHomeTownTbx.Clear(); //-||-
                AuthorGenreTbx.Clear(); // -||- 
                AuthorStartYearTbx.Clear(); // -||-
            }
            catch (Exception Ex) //funker inte detta så...
            {
                MessageBox.Show(Ex.Message); //Visas ett felmeddelande! 
            }

            AuthorBS.DataSource = from allAuthors in db.Authors //Visa denna tabell och sortera den såhär!
                                  orderby allAuthors.Author_Name
                                  select allAuthors;

            BooksAuthorNameCbx.DataSource = from cbxData in db.Authors //Sortera comboboxen såhär och visa den såhär!
                                            orderby cbxData.Author_Name
                                            select cbxData;
        }

        private void AuthorRemoveBtn_Click(object sender, EventArgs e)
        {
            if (AuthorDGV.SelectedRows.Count == 1) //Om man markerar en rad...
            {
                int selected_ID = (int)AuthorDGV.SelectedRows[0].Cells[0].Value; //Väljer det ID:et.
                Author a = db.Authors.Single(author => author.Author_ID == selected_ID); // -||-

                db.Authors.DeleteOnSubmit(a); //Ta bort när man trycker på knappen i A.
                db.SubmitChanges(); //Ändra.

                AuthorBS.DataSource = from allAuthors in db.Authors //Visa denna tabell och sortera den såhär!
                                      orderby allAuthors.Author_Name
                                      select allAuthors;

                BooksAuthorNameCbx.DataSource = from cbxData in db.Authors //Visa comboboxen i Books såhär och sortera den såhär!
                                                orderby cbxData.Author_Name
                                                select cbxData;
            }
        }

        int AuthorChangeState = 0;
        int AuthorTempID;
        private void AuthorChangeBtn_Click(object sender, EventArgs e)
        {
            if (AuthorChangeState == 0) //Om AuthorChange är noll...
            {
                if (AuthorDGV.SelectedRows.Count == 1) //Och man har markerat en rad...
                {
                    int selected_ID = (int)AuthorDGV.SelectedRows[0].Cells[0].Value; //Så kommer det ID:et att väljas...
                    Author a = db.Authors.Single(author => author.Author_ID == selected_ID); 

                    AuthorTempID = a.Author_ID; //TempID motsvarar Author_ID
                    AuthorNameTbx.Text = a.Author_Name; //AuthorName i DGV:n är Author_Name
                    AuthorAgeTbx.Text = a.Age.ToString(); //att Age i DGV:n är Age.
                    AuthorGenreTbx.Text = a.Genre; // att Genre i DGV:n är Genre.
                    AuthorHomeTownTbx.Text = a.Born_In; //att Hometown i DGV:n motsvarar Born_In
                    AuthorStartYearTbx.Text = a.Startyear; //att startyear i DGV:n motsvarar startyear
                    AuthorSaveBtn.Visible = false; //att save knappen inte ska visas under tiden som man fyller i ändringar för att ingen ska klicka fel. (Jag själv gjorde det misstaget 20 gånger)

                    AuthorChangeState = 1; //Att du är klar med ändringarna.
                }
            }
            else 
            {
                try
                {
                    Author a = db.Authors.Single(authors => authors.Author_ID == AuthorTempID); //Att samma ID ska väljas.
                    a.Author_Name = AuthorNameTbx.Text; 
                    a.Age = int.Parse(AuthorAgeTbx.Text);
                    a.Born_In = AuthorHomeTownTbx.Text;
                    a.Genre = AuthorGenreTbx.Text;
                    a.Startyear = AuthorStartYearTbx.Text;

                    db.SubmitChanges(); //Och allt ändras tillbaka.

                    BooksAuthorNameCbx.DataSource = from cbxData in db.Authors //Och comboboxen ska uppdateras.
                                                    orderby cbxData.Author_Name
                                                    select cbxData;
                }
                catch (Exception Ex) //Funkar inte detta så visas ett felmeddelande.
                {
                    MessageBox.Show(Ex.Message);
                }
                AuthorSaveBtn.Visible = true; //När allt är klart så visas save button igen
                AuthorChangeState = 0; // Och du kan ändra igen ovanpå dina ändringar.
            }
                
        }

        private void AuthorSearchBtn_Click(object sender, EventArgs e)
        {
            if (AuthorSearchTbx.Text.Trim().Length > 0) //Om längden på texten är större än 0.
            {
                string srchWord = AuthorSearchTbx.Text.Trim().ToLower(); //SrchWord är texten du skriver in i sökrutan.

                var srchResult = from result in db.Authors //Ta resultaten ifrån Authors
                                 where result.Author_ID.ToString().Contains(srchWord) //Om sökordet innehåller Author_ID så sök på det
                                    || result.Age.ToString().Contains(srchWord) //Om sökordet innehåller age så sök på det.
                                    || result.Author_Name.ToLower().Contains(srchWord) // Om sökordet innehåller author_name så sök på det.
                                    || result.Born_In.ToLower().Contains(srchWord) // Om sökordet innehåller Born_in så sök på det.
                                    || result.Genre.ToLower().Contains(srchWord) // om sökordet innehåller Genre så sök på det.
                                    || result.Startyear.ToLower().Contains(srchWord) // om sökordet innehåller startyear så sök på det.
                                 orderby result.Author_Name //ordna enligt Author_name
                                 select result; //Välj.

                AuthorBS.DataSource = srchResult;
            }
            else
            {
                AuthorBS.DataSource = from allAuthors in db.Authors //Om du inte söker på något (tom ruta) så ska ingenting hända.
                                      orderby allAuthors.Author_Name
                                      select allAuthors;
 
            }
        }

        private void AuthorClearBtn_Click(object sender, EventArgs e)
        {
            AuthorBS.DataSource = from allAuthors in db.Authors //Om du inte söker på något (tom ruta) så ska ingenting hända.
                                  orderby allAuthors.Author_Name
                                  select allAuthors;

        }
        #endregion
        #region Books
        private void BooksSaveBtn_Click(object sender, EventArgs e)
        {
            Book b = new Book();

            try
            {
                b.Author = (int)BooksAuthorNameCbx.SelectedValue;
                b.Book_Name = BooksBookNameTbx.Text;
                b.BookLanguage = BooksLanguageTbx.Text;
                b.ReleaseYear = BooksReleaseYearTbx.Text;

                db.Books.InsertOnSubmit(b);
                db.SubmitChanges();

                BooksBookNameTbx.Clear();
                BooksLanguageTbx.Clear();
                BooksReleaseYearTbx.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            BooksBS.DataSource = from allBooks in db.Books
                                 orderby allBooks.Book_Name
                                 select allBooks;
        }

        private void BooksRemoveBtn_Click(object sender, EventArgs e)
        {
            if (BooksDGV.SelectedRows.Count == 1)
            {
                int selected_ID = (int)BooksDGV.SelectedRows[0].Cells[0].Value;
                Book b = db.Books.Single(book => book.Book_ID == selected_ID);

                db.Books.DeleteOnSubmit(b);
                db.SubmitChanges();

                BooksBS.DataSource = from allBooks in db.Books
                                     orderby allBooks.Book_ID
                                     select allBooks;
            }

        }

        int BooksChangeState = 0;
        int BooksTempID;
        private void BooksChangeBtn_Click(object sender, EventArgs e)
        {
            if (BooksChangeState == 0)
            {
                if (BooksDGV.SelectedRows.Count == 1)
                {
                    int selected_ID = (int)BooksDGV.SelectedRows[0].Cells[0].Value;
                    Book b = db.Books.Single(book => book.Book_ID == selected_ID);

                    BooksTempID = b.Book_ID;
                    BooksAuthorNameCbx.SelectedValue = b.Author;
                    BooksLanguageTbx.Text = b.BookLanguage;
                    BooksReleaseYearTbx.Text = b.ReleaseYear;
                    BooksBookNameTbx.Text = b.Book_Name;
                    BooksSaveBtn.Visible = false;

                    BooksChangeState = 1;
                }
            }
            else
            {
                try
                {
                    Book b = db.Books.Single(book => book.Book_ID == BooksTempID);
                    b.Book_Name = BooksBookNameTbx.Text;
                    b.BookLanguage = BooksLanguageTbx.Text;
                    b.Author = (int)BooksAuthorNameCbx.SelectedValue;
                    b.ReleaseYear = BooksReleaseYearTbx.Text;

                    db.SubmitChanges();

                    BooksDGV.DataSource = from allBooks in db.Books
                                          orderby allBooks.Book_Name
                                          select allBooks;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                BooksChangeState = 0;
                BooksSaveBtn.Visible = true;
            }

        }

        private void BooksSearchBtn_Click(object sender, EventArgs e)
        {
            if (BooksSrchTbx.Text.Trim().Length > 0)
            {
                string srchWord = BooksSrchTbx.Text.Trim().ToLower();

                var srchResult = from result in db.Books
                                 where result.Book_ID.ToString().Contains(srchWord)
                                    || result.Book_Name.ToString().Contains(srchWord)
                                    || result.ReleaseYear.ToLower().Contains(srchWord)
                                    || result.BookLanguage.ToLower().Contains(srchWord)
                                    || result.Author.ToString().Contains(srchWord)
                                 orderby result.Book_Name
                                 select result;

                BooksBS.DataSource = srchResult;
            }
            else
            {
                BooksBS.DataSource = from allBooks in db.Books
                                     orderby allBooks.Book_Name
                                     select allBooks;

            }
        }

        private void BooksClearBtn_Click(object sender, EventArgs e)
        {
            BooksBS.DataSource = from allBooks in db.Books
                                 orderby allBooks.Book_Name
                                 select allBooks;
        }
        #endregion
    }
}
