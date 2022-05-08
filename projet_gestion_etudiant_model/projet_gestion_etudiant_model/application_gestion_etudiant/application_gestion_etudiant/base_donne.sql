CREATE SCHEMA `gestion_etudiant` ;
use gestion_etudiant;

CREATE TABLE filiere  (
  id INT NOT NULL AUTO_INCREMENT,
  code VARCHAR(45) unique  NOT NULL,
  designation VARCHAR(45) NULL,
  PRIMARY KEY (id, code)
 );
 ---------------------------------------------------------------------

 CREATE TABLE module (
  id INT NOT NULL AUTO_INCREMENT,
  code VARCHAR(45) unique NOT NULL,
  designation VARCHAR(45) NULL,
  niveau INT NULL, 
  semestre VARCHAR(45) NULL,
  code_fil VARCHAR(45) NULL,
  PRIMARY KEY (id, code),
  CONSTRAINT fk_code_fil FOREIGN KEY (code_fil) REFERENCES filiere (code)
   );
  ----------------------------------------------------- 
  
  CREATE TABLE matiere (
  id INT NOT NULL AUTO_INCREMENT,
  code VARCHAR(45) unique NOT NULL,
  designation VARCHAR(45) NULL,
  vh INT NULL,
  code_module VARCHAR(45) NULL,
  PRIMARY KEY (id, code),
  CONSTRAINT fk_code_module FOREIGN KEY (code_module) REFERENCES module (code)
 );


CREATE TABLE eleve (
  id INT NOT NULL AUTO_INCREMENT,
  code VARCHAR(45)unique NOT NULL,
  nom VARCHAR(45) NULL,
  prenom VARCHAR(45) NULL,
  niveau INT NULL,  
  code_fil VARCHAR(45) NULL,
  PRIMARY KEY (id,code),
  CONSTRAINT fk_code_fil1 FOREIGN KEY (code_fil) REFERENCES filiere (code)
   );

CREATE TABLE notes (
  id INT NOT NULL AUTO_INCREMENT,
  code_eleve VARCHAR(45)  NOT NULL,
  code_mat VARCHAR(45)  NOT NULL,
  note DOUBLE NULL,
  PRIMARY KEY (id, code_eleve,code_mat),
  CONSTRAINT uniqueCouple UNIQUE (code_eleve,code_mat),
  CONSTRAINT fk_code_eleve
    FOREIGN KEY (code_eleve)
    REFERENCES eleve (code),
  CONSTRAINT fk_code_mat
    FOREIGN KEY (code_mat)
    REFERENCES matiere (code)
);

CREATE TABLE moyennes (
  id INT UNSIGNED NOT NULL AUTO_INCREMENT,
  code_eleve VARCHAR(45) NOT NULL,
  code_fil VARCHAR(45) NOT NULL,
  niveau INT NOT NULL,
  moyenne DOUBLE NULL,
  PRIMARY KEY (id, code_eleve, code_fil, niveau),
   CONSTRAINT uniqueCouple2 UNIQUE (code_eleve,code_fil),
  CONSTRAINT fk_code_eleve1
    FOREIGN KEY (code_eleve)
    REFERENCES eleve (code),
  CONSTRAINT fk_code_fil2
    FOREIGN KEY (code_fil)
    REFERENCES filiere (code)
);
   
/*-------------------------------------------------------------------------------------------*/

--data:



/*
select * from filiere;
update filiere set code='AP',designation='Annee preparatoire ' where id=1;
update filiere set code='GINF',designation='Genie informatique' where id=2;
update filiere set code='GSTR',designation='Genie Reseaux ' where id=3;
update filiere set code='GSEA',designation='Genie de system electronique et automatique' where id=4;
update filiere set code='GIL',designation='genie industrielle'where id=5;
update filiere set code='G3EI',designation="genie d'energie d'environnemnt renvelable" where id=6;
*/
insert into filiere (code,designation) values ('AP','Annee preparatoire');
insert into filiere (code,designation) values ('GINF','Genie informatique');
insert into filiere (code,designation) values ('GSTR','Genie Reseaux');
insert into filiere (code,designation) values ('GSEA','Genie de system electronique et automatique');
insert into filiere (code,designation) values ('GIL','genie industrielle et logistique');
insert into filiere (code,designation) values ('G3EI',"genie d'environnemnt renvelable");



insert into module(code,designation,niveau,semestre,code_fil) values ('GINF21','optimisation et securiser data base de donne',2,'S8','GINF');
insert into module(code,designation,niveau,semestre,code_fil) values ('GINF22','php et development web',1,'S6','GINF');
insert into module(code,designation,niveau,semestre,code_fil) values ('GINF23','crythographie et securiter de system',2,'S8','GINF');
insert into module(code,designation,niveau,semestre,code_fil) values ('GINF25','java et xml',2,'S7','GINF');
insert into module(code,designation,niveau,semestre,code_fil) values ('GINF24','service web et spring boot',3,'S9','GINF');

insert into matiere(code,designation,vh,code_module) values ('GINF21_1','optimisation BD',23,'GINF21');
insert into matiere(code,designation,vh,code_module) values ('GINF21_2','securiser BD',25,'GINF21');
insert into matiere(code,designation,vh,code_module) values ('GINF22_1','php',30,'GINF22');
insert into matiere(code,designation,vh,code_module) values ('GINF22_2','javascript',21,'GINF22');
insert into matiere(code,designation,vh,code_module) values ('GINF25_2','java',40,'GINF25');
insert into matiere(code,designation,vh,code_module) values ('GINF25_1','xml',25,'GINF25');

insert into eleve(code,nom,prenom,niveau,code_fil) values ('E10','kharchich','mouaad',2,'GINF');
insert into eleve(code,nom,prenom,niveau,code_fil) values ('E11','khettab','ziyad',2,'GINF');
insert into eleve(code,nom,prenom,niveau,code_fil) values ('E12','kssiri','akram',2,'GINF');
insert into eleve(code,nom,prenom,niveau,code_fil) values ('E13','hassis','youssef',2,'GINF');
insert into eleve(code,nom,prenom,niveau,code_fil) values ('E14','Oukil','mouaad',2,'GINF');

insert into notes(code_eleve,code_mat,note) values('E11','GINF21_1',11.99);
insert into notes(code_eleve,code_mat,note) values('E11','GINF21_2',14);
insert into notes(code_eleve,code_mat,note) values('E11','GINF25_2',13);
insert into notes(code_eleve,code_mat,note) values('E11','GINF25_1',17);

insert into notes(code_eleve,code_mat,note) values('E10','GINF21_1',11.5);
insert into notes(code_eleve,code_mat,note) values('E10','GINF21_2',19.7);
insert into notes(code_eleve,code_mat,note) values('E10','GINF25_2',17);
insert into notes(code_eleve,code_mat,note) values('E10','GINF25_1',14);

insert into notes(code_eleve,code_mat,note) values('E12','GINF21_1',13);
insert into notes(code_eleve,code_mat,note) values('E12','GINF21_2',13.98);
insert into notes(code_eleve,code_mat,note) values('E12','GINF25_2',17);
insert into notes(code_eleve,code_mat,note) values('E12','GINF25_1',16);

insert into notes(code_eleve,code_mat,note) values('E13','GINF25_1',20);
insert into notes(code_eleve,code_mat,note) values('E13','GINF25_2',13);
insert into notes(code_eleve,code_mat,note) values('E13','GINF21_1',18);
insert into notes(code_eleve,code_mat,note) values('E13','GINF21_2',19);




DELIMITER $$
USE `gestion_etudiant`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Modifier`(In code_eleve varchar(45),In code_mat varchar(45),In note DOUBLE)
BEGIN
update notes set notes.note=note where notes.code_eleve=code_eleve and notes.code_mat=code_mat;
END
DELIMITER ;
;

DELIMITER $$
USE `gestion_etudiant`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Inserer`(In code_eleve varchar(45),In code_mat varchar(45),In note DOUBLE)
BEGIN
insert into  notes(note,code_eleve,code_mat) values (note,code_eleve,code_mat);
END
DELIMITER ;
;

DELIMITER $$
USE `gestion_etudiant`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Supprimer`(In code_eleve varchar(45),In code_mat varchar(45))
BEGIN
delete from notes where notes.code_eleve=code_eleve and notes.code_mat=code_mat;
END
DELIMITER ;
;



/*********************************************************************/
procedure :

delimiter //
create procedure Selection_Data(IN moyenne float)
begin
insert into 
insert into moyennes (code_eleve,code_fil,niveau,moyenne) values ('E1','F10','2',moyenne);
end//
delimiter


Trigger moyenne:

/*insert*/

delimiter //
create trigger Insertion_Moyennes
after insert on notes
for each row 
begin
declare moyenne float;
declare niv varchar(45);
declare Code_fil varchar(45);
declare num_Matiere int;
declare num_notes int;


select avg(note) into moyenne from notes where code_eleve=new.code_eleve;
select niveau into niv from eleve where code = new.code_eleve;
select f.code into Code_fil from filiere f , eleve e where e.code_fil=f.code and e.code=new.code_eleve;

select count(*) into num_Matiere from filiere f , module mo , matiere ma
 where f.code=mo.code_fil  and mo.code=ma.code_module and f.code=Code_fil and mo.niveau=niv;

select count(*) into num_notes from notes where code_eleve=new.code_eleve;
if (num_Matiere = num_notes) then
insert into moyennes (code_eleve,code_fil,niveau,moyenne) values (new.code_eleve,Code_fil,niv,moyenne);
end if;
END//

/*delete*/

delimiter //
create trigger delete_Moyennes
after delete on notes
for each row 
begin
delete from moyennes where code_eleve=old.code_eleve;
END//


--supprimer une seul ligne ??? 
/*update */


delimiter //
create trigger update_Moyennes
after update on notes
for each row 
begin
declare moyenne float;
select avg(note) into moyenne from notes where code_eleve=new.code_eleve;
update moyennes set moyenne=moyenne where code_eleve=new.code_eleve;
END//



// 1 
            OPEN Connection : MysqlConnection:
            // 2
             MysqlParamter []pms =new MysqlParameter[1];
            pms[0]=new MysqlParameter("fn",MySqlDbType.VarChar); // name prametre et type comme Int32
            pms[0].Value=textBoxFName.Text;
            
            MysqlCommand command=new MysqlCommand();
            command.Connection=connection;
            command.CommandType=CommandType.StoreProcedure;
            command.CommandText="" // name procedure stock

            command.Paramters.AddRange(pms);
            if(command.ExecuteNonQuery()==1){
            MessageBox.show("YES");
            }else{
                 MessageBox.show("Non");
            }
            connection.Close();