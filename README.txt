Installation de VitAdmin :
	Extraire l'archive .zip
	Cr�er une base de donn�e MySql
	Ex�cuter le script "vitadmin_bd_main.sql" (inclus dans l'archive) sur la base de donn�e cr��e pr�c�demment

Param�trage
	Ouvrire le fichier /Configuration/ChainesConnexion.config
	Modifier l'attribut �connectionString=�, � la ligne qui commence par �<add name="MySql"�
		Mettre les informations de votre serveur de base de donn�e, dans le format suivant:
			�Server=[adresseIP]; database=[nomBD]; UID=[Usager]; password=[Mot de passe]; SslMode=none�
	Modifier l'attribut �connectionString=�, � la ligne qui commence par �<add name="FTP"�
		Mettre les informations de votre serveur de Fichier, dans le format suivant:
			�connectionString="L'ALIAS DE MON SERVEUR FTP"�

Ex�cuter l'application
	Ex�cuter le fichier "VitAdmin.exe"

Usagers pour tester
   Un administrateur
	Nom : "Admin"
	Mot de passe : ""

   et
   
	Pour tester les �crans de gestions des dossiers d'un patient
   Un professionnel
	Nom : "TherienJ"
	Mot de passe : ""
   
   et
   	Pour tester l'�cran de l'horaire de la semaine courante
   Un professionnel
	Nom : "Bas"
	Mot de passe : ""
	