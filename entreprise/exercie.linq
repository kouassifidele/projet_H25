<Query Kind="Statements">
  <Namespace>System.Windows.Documents</Namespace>
</Query>



Entreprise E1 = new Entreprise


class Entreprise
{
	private string _nomEntreprise;
	private readonly List<string> _Employé;
	
	public Entreprise(string nomEntrepise, string[] employé)
	{
		SetNomEntreprise(nomEntrepise);
		SetEmployé(employé);
	}

	void SetNomEntreprise(string nomEntreprise)
	{
		throw new ArgumentException();
	}
	void SetEmployé(string[] employé)
	{
		throw new ArgumentException();
	}


	public string NomEntreprise => _nomEntreprise;
	
	public IReadOnlyList<string> Employe => _Employé;


	public void AjouterEmployé(string employé)
	{
		_Employé.Add(employé);
	}
	
	public void AfficherEmployé()
	{
		($" Entreprise: {NomEntreprise}").Dump();
		($" Liste des employés: {AjouterEmployé}").Dump();

	}
}