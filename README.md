# **Applications MediaTek86**

Application C# écrite sous Visual Studio 2022 Entreprise et exploitant une BDD MySQL.


## **Présentation de l'application**

### **Présentation du contexte**

Afin de développer un projet dans un contexte réaliste d’entreprise, je vous propose le contexte MediaTek86, un réseau qui gère les médiathèques de la Vienne, et qui a pour rôle de fédérer les prêts de livres, DVD et CD et de développer la médiathèque numérique pour l’ensemble des médiathèques du département.<br />
Je travaille en tant que technicien développeur junior pour l’ESN InfoTech Services 86 qui vient de remporter le marché pour différentes interventions au sein du réseau MediaTek86, dont certaines dans le domaine du développement d'application.<br />
Cette application est monoposte et sera installée sur un poste du service administratif.<br />
Elle sera écrit en C# et utilisera MySQL en SGBD pour la base de données.<br />

### **But de l'application**

Le responsable souhaite avoir un **un petit utilitaire pour gérer le personnel. leur service attribué** IL souhaite aussi pouvoir **gérer les absences d'un personnel selectionné en amont**.
L'application MediaTek86 représente cet utilitaire.
L'application doit permettre de :
  - Présenter la liste du personnel (nom, prénom, tel, mail, service) sachant qu'il existe une liste déterminée de service (administratif, médiation culturelle et prêt).
  - Permettre d'ajouter un personnel
  - Permettre de modifier ou supprimer un personnel
  - Présenter la liste d'absence d'un personnel sélectionné (date de début, date de fin, motif) sachant qu'il existe une liste déterminée de motif (vacances, maladie, motif familial, congé parental)
  - Permettre d'ajouter une absence à un personnel
  - Permettre de modifier ou supprimer une absence d'un personnel
La liste des services et des motifs sont fixes et non modifiable via cette application.

### **Structure de la bdd :**

Voici le schéma conceptuel de données présentant la structure de la BDD qui est au format MySQL : <br /><br />
![alt text](https://github.com/Neeeme/MediaTek86_Atelier2/blob/master/Image/DiagrammePaquetage.png "Structure de la bdd")

### **Interfaces**

Voici les différentes fenêtres de l'application :

![alt text](https://github.com/Neeeme/MediaTek86_Atelier2/blob/master/Image/Interface.png "Différentes fenêtres de l'application")

### **Diagramme de paquetage :**

L'application est structurée dans le respect du pattern MVC.

![alt text](https://github.com/Neeeme/MediaTek86_Atelier2/blob/master/Image/diagramme.png "Diagramme de paquetage de l'application")

**Présentation du cheminement :**

L'application démarre sur une vue Authentification. <br />
La vue crée une instance du contrôleur qui lui est dédié, donc chaque vue a son propre contrôleur. (FrmAuthentification = FrmAuthentificationController..)<br />
Le contrôleur fait appel aux classes de la couche 'dal' pour les exécuter les demandes de la vue. (FrmAuthentification (vue) appelle FrmAuthentificationController (controller) qui appelle ResponsableAccess (dal) par-exemple.)<br />
Les classes de la couche 'dal' ont des requêtes qui néceissent la couche 'bddmanager' pour qu'elles soient correctement exécutés. Chaque couche 'dal' a aussi une classe métier qui lui est liée, et ces classes métiers sont contenus dans 'model'.<br />
Elles correspondent aux tables de la base de données, et contiennent uniquement la structure des données. 'bddmanager' est la seule exception, qui est entièrement indépedante du programme et qui peut être utilisé dans n'importe quelle application.<br />

## **Etape de construction**

Les différents commits montrent la création de l'application étape par étape.

### Commit "création des différents fichiers en respectant la structure"

La structure de l'application est créée (seulement les fichiers donc bddmanager, controller, dal, model et view)

### Commit "Ajout de bddmanager.cs"

Insertion de bddmanager.cs dans le fichier bddmanager afin de se connecter à la base de données et effectuer des requêtes SQL.

### Commit "création des fichiers requis pour l'utilisation du logiciel"

L'intégralité des classes ont été crées mais sont vides pour l'instant. 

### Commit "ajout de l'interface des 3 views"

Les 3 interfaces ont été entièrement faites.

### Commit "Ajout de la fonctionnalité de connexion (vérification en bdd que le compte existe)"

La fenêtre d'authentification donc FrmAuthentification, ainsi que FrmAuthentificationController, ResponsableAccess, Access(dal), Responsable(model), Access(model) ont été entièrement codés afin d'assurer une connexion et une vérification en base de données que le compte existe bel et bien.

### Commit "Ajout remplissage liste personnel"

Remplissage de FrmMediaTek86, FrmMediaTek86Controller, Personnel(model), PersonnelAccess et Service(model) ont commencé à être codé et sont désormais fonctionnel pour l'affichage du personnel ainsi que leur service attribué après la connexion.

### Commit "Ajout remplissage liste services dans combo box"

Ajout fonction RemplirListeServices(); dans FrmMediaTek86, GetLesServices() dans FrmMediaTek86Controller et ServiceAccess afin de pouvoir remplir la combo box avec les différents services disponibles.

### Commit "Ajout fonction pour ajouter un nouveau personnel"

Suite du remplissage de FrmMediaTek86, FrmMediaTek86Controller, PersonnelAccess afin d'assurer le bon remplissage de la base de données par un nouveau personnel lorsque celui-ci est ajouté.

### Commit "Ajout fonctionnalité modification personnel + annulation enregistrement/modification"

Suite du remplissage de FrmMediaTek86, FrmMediaTek86Controller, PersonnelAccess afin d'assurer la bonne modification dans la base de données d'un personnel lorsque celui-ci est modifié. <br />
Codage du bouton annuler qui permet d'annuler un enregistrement ou une modification d'un personnel.

### Commit "Ajout suppression d'un personnel"

Suite du remplissage de FrmMediaTek86, FrmMediaTek86Controller, PersonnelAccess afin d'assurer la bonne suppression dans la base de données du personnel sélectionné.

### Commit "Remplissage de la liste des absences lors de la sélection d'un personnel et puis en appuyant sur le bouton absence"

Remplissage de FrmMediaTek86, FrmAbsence, FrmAbsenceController, Absence(model), AbsenceAccess, motif(model) afin d'assurer le remplissage de la liste d'absence d'un personnel lorsque celui-ci est selectionné et que l'on clique sur le bouton "Absence".

### Commit "Ajout remplissage liste motif"

Ajout fonction RemplirListeMotif(); dans FrmAbsence, GetLesMotifs() dans FrmAuthentificationController et MotifAccess afin de pouvoir remplir la combo box avec les différents motifs disponibles.

### Commit "Ajout remplissage du nom prénom du personnel selectionné dans la frame absence"

Simple ajout du nom et prénom dans la frame Absence.

### Commit "Ajout fonctionnalité d'ajouter une absence sur un personnel selectionné"

Suite du remplissage de FrmAbsence, FrmAbsenceController, AbsenceAccess afin d'assurer le bon remplissage dans la base de données d'une absence sur un personnel sélectionné lorsque celui-ci est ajouté. 

### Commit "Ajout fonctionnalité de modifier une absence selectionné + confirmation de modification"

Suite du remplissage de FrmAbsence, FrmAbsenceController, AbsenceAccess afin d'assurer la bonne modification dans la base de données d'une absence sur un personnel sélectionné lorsqu'elle confirme la modification.

### Commit "Ajout fonctionnalité de supprimer une absence sélectionné + confirmation de suppression"

Suite du remplissage de FrmMediaTek86 afin d'avoir une meilleure confirmation de modification d'un personnel. <br />
Suite du remplissage de FrmAbsence, FrmAbsenceController, AbsenceAccess afin d'assurer la bonne suppression dans la base de données d'une absence sur un personnel sélectionné.

### Commit "Ajout annulation d'enregistrement/modification d'une annonce"

Codage du bouton annuler qui permet d'annuler un enregistrement ou une modification d'une absence.

### Commit "Correction bug de ne pas pouvoir ajouter un personnel s'il n'en existe aucun"

Bug sur l'index de la liste du personnel qui n'était pas défini lorsque la base de données ne contenait aucun personnel et qu'on essayait d'en ajouter un nouveau

### Commit "enlevage du login pwd dans frm authentification"

Suppression du login & pwd déjà écrit dans FrmAuthentification

### Commit "Ajout QOL de moi-même : supprimer les absences d'un personnel lorsqu'on supprime un personnel"

Ajout de la suppression de l'intégralité des absences d'un personnel lorsque-celui est supprimé pour éviter d'avoir trop d'absences en base de données qui appartiennent à des personnes qui n'existent plus. (Ce n'était pas demander dans l'atelier mais j'ai préféré le rajouter de moi-même pour une meilleure qualité)

## **Installation**

Il est possible de tester l'application pour chaque commit effectué, ou de tester la version finale en téléchargeant directement l'installateur.<br />
Pour tester une version, il faut s'assurer d'avoir un environnement de développement.<br />
Je vous conseille d'installer WampServer, cela sera plus simple, mais voici une liste des outils suivants nécessaire.<br />
  . SGBDR MySQL<br />
  . Un IDE pour manipuler du code (l'application été réalisée sous Visual Studio 2022 donc c'est la meilleure option)<br />
Il faut ensuite :<br />
  . Dans MySQL, exécuter le script contenu dans sql/atelier.sql pour pouvoir créer et remplir la base de données.<br />
  . Récupérer le code du commit voulu et l'ouvrir dans l'IDE, puis l'exécuter.
