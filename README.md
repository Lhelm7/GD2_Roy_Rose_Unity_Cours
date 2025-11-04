# BRASSART_GD2_Unity_RollABall
Par rapport à la base qu’on avait (balle mobile, marquage de points quand on touche des collectibles) les compléments qu’on doit ajouter et mes compétences assez faibles sur unity et en programmation de manières générale, j’ai décidé de rester sur des choses simples en faisant un jeu de plateforme. Ainsi je suis resté sur des idées et des compléments à ma portée (pour la majorité des codes)  

Idée jeu d’arcade : 

Jeu de plateforme, avec un level design inspiré de tron (futuriste/technologique), dans lequel le joueur va devoir réussir à retrouver tous les collectible “énergies” présents dans le niveau. Ces collectibles énergies, permettent donc comme leur nom l’indique d’apporter de l’énergies aux joueurs, et représente ainsi en quelque sorte sa vie. 

Si le joueur vient à mourir (exemple ; tombe dans un piège) alors qu’il n’avait récupéré aucun collectible énergie c’est le game over. 

Mais si le joueur récupère plusieurs collectible (par exemple ; à six énergies) s'il vient à mourir, alors il respawn au point où il spawner au départ, et perd un collectible, il descend à 5, et le dernier collectible qu’il à ramasser respawn dans le monde à l’endroit où il l’avait récupéré. Il devra donc aller le récupérer à nouveaux. Mais ainsi tant qu’il ne tombe pas à 0 il ne fait pas game over. 

Pour gagner le joueur devra parvenir à récupérer tous les collectibles présents dans le niveau. 


Rajout à cette base  

Base : un jeu fonctionnel avec plusieurs niveaux, une balle mobile, du marquage de points quand on touche des collectibles, du sound design de base, des menus de base (start, victoire, défaite), bien évidement des conditions de victoire ou défaite, une apparition de gameobjects conditionnelle (comme les murs dans le cours par exemple). 


Menus  

Objectif : trois menu (start, victoire, défaite)  


Réalisation : j’ai réalisé un “main menu” quand le joueur lance le jeu. Un Menu game over quand le joueur perd (le joueur perd quand il a perdu tous ses collectibles énergies et qu’il meurt en tombant dans des pièges, si collectible = 0 et qu’il meurt alors game over) et un menu victory à la fin des level. (Le joueur gagne quand il a récupéré tous les collectible énergies présent sur le niveau) 


Sound design  

Objectif : Rajouter un son ; au jump / au dash / quand on récupère des collectibles / quand le joueur meurt / quand le joueur gagne / et quand il clique sur des boutons d'UI. 

Problème rencontré : pour l'UI, le son des boutons ne se joue pas car on quitte le niveau pour en ouvrir un autre. Seulement j’ai peur de devoir avoir un faire un code plus complexe que prévue pour pallier ce problème, ou alors faire en sorte de laisser un temps de délai entre le moment ou le son se joue et ou l’on change de niveau. 


Sound design bonus : rajouter plus de son environnemental sans que ce soit une pollution sonore exemple piège qui s’ouvre plateforme qui bouge musique entrainante. 
 

Conditions de victoire ou défaite 

Objectif :  

- (Victoire) Quand le joueur récupère tous les collectible présent dans le niveau il gagne 

- (Défaite) Quand le joueur tombe dans un piège et traverse la dead zone avec 1 ou 0 collectible énergie récupéré il fait game over (UI game Over s’affiche). 

Réalisation :  

(Victoire) j’ai récupéré le score data et j’ai fait en sorte de comparer le score du joueur avec une autre variable, que je peux actualiser dans l’inspector (cette variable correspond au nombre de collectible que doit avoir récupérer le joueur pour gagner le niveau.) ainsi si cette variable est égale au score data, le joueur gagne (UI victory s’affiche) et il peut passer au niveau suivant. 

Également ayant eu quelques petits problèmes lors de la réalisation du code, je ne savais pas et n’arrivai pas à savoir comment lancer mon script ou le déclencher, donc j’ai fait une box victory et mis le script dedans ainsi quand le joueur la traverse et qu’il a le bon nombre de collectible l’ui s’affiche.  

(Défaite) Contrairement à la victoire la défaite se lance 

 

Apparition de game objects conditionnelle  

Objectif :  

-Porte qui s’ouvre quand le jouer passe devant 

-Porte qui s’ouvre quand le joueur à récupérer un nombre spécifique de collectible 

Réalisation : J’ai fait deux portes différentes. Le code est très simple mais je suis contente car c’est un des premiers codes que j’ai réalisé facilement sans problème, et sans aide. 

Ainsi la première porte détecte si c’est bien le joueur qui passe dans la box et si c’est le cas elle se détruit. Et l’autre vérifie également si c’est bien le joueur qui passe dans la box collider, mais elle vérifie également si le joueur à un score égale à un certains pallier (exemple le joueur à récupérer 2 collectible, mais un texte s’affiche lui disant qu’il lui faut trois collectible pour pouvoir passer) cela permet de faire du back tracking le joueur sait qu’il peut passer par là mais pas tout de suite. Ainsi quand il repassera avec le bon nombre de collectible la porte se détruira.  

Plusieurs niveaux  

Objectif : deux niveaux ; un niveau simple, présentant les bases, et un niveau plus complexe, mettant en avant le deuxième collectible “dash” et des plateforme plus complexe (plateforme qui disparait et qui bouge en même temps) mélange de script entre code impliquant du temps, et l’autre des plateforme transform. 


collectible supplémentaire 

Base : un ajout d'une logique de collection supplémentaire, donc un nouveau type de collectible, l'UI associée et un effet en jeu. Exemple : des clefs pour ouvrir une porte. 

Collectible Dash 
 
Objectif :  

Objectif : Le collectible que j’ai décidé d’ajouter est un collectible “dash”, afin de ne pas “jeter” le code du dash que j’avais fait j’ai décidé de le réutiliser afin d’en faire un collectible, ainsi le dash ne serait pas utilisable constamment mais serait un bonus, un complément dans certains passages du level. Une fois le collectible récupéré, un petit logo apparaitrait sur le bas de l’écran, également accompagné d’une barre qui représenterait le temps d’utilisation du dash (environ 5seconde) ainsi une fois le dash utilisé la barre s’écoulerait et une fois à terme le logo et la barre disparaitrait de l’écran et le joueur ne pourra plus utiliser le dash 

Pour faire le collectible j’ai repris la logique vue en clase. 

J'ai fait un script et un game object, j’ai glissé le script sur l’objet, et ainsi quand le joueur traverse la box collider de l’objet dans le monde ce dernier disparait. Mais il fallait faire une sorte de transmission, et d’activation de ce pouvoir, quand on récupère le game object ce dernier s’active alors pour le joueur. Ainsi avant que le game object soit détruit j’active un event présent dans le script dash présent sur le joueur, mais qui était alors inaccessible, cette activation le rendant utilisable. 

Mais aussi quand on ramasse l’objet j’ai également rajouté une image dans l’ui controller afin d’afficher le logo dash, et une barre fill amount, mais ce code s’active dans le script dash, et pas dans le script du collectible.  

  

Ajout temps  

Base : un effet lié au temps. Par exemple augmentation de vitesse, gain de points bloqué etc. 

Plateforme qui disparait (piège) 

Réalisation : inspiré de la base du code fait sur le game object soft target vu en cours ou cette dernière disparaissait et réapparaissait au bout d’un certain temps. 

Je compte reprendre les notions de coroutine pout gérer le temps, et de mesh renderer / collider enabled, pour faire apparaitre et disparaitre simplement les plateformes, et pouvoir gérer une variable de temps 

Réalisation : ces plateformes sont comme des pièges qui apparaissent et disparaisse au bout d’un certain temps, j’ai pu ainsi faire deux variable visible et invisible, définissant combien de temps ces dernière restent visible et (colider et mesh renderer activé ou désactivé) je change les valeurs dans l’inspector. En fonction du temps que je veux. 


Dash Bar 

Objectif ; faire une barre qui se décrémente visuellement dans lui, en fonction d’une durée prédéfini dans le script 

Réalisation : le code de la barre se trouvent dans le script dash et s’affiche quand le joueur récupère le collectible, en revanche elle se déclenche (décrémente) quand le joueur commence à dasher, cela déclenche alors plusieurs variables permettant de soustraire et de décrémenter le temps du dash (remaingtime – deltatime). Une fois le temps finit elle se désactive et s’enlève de l’écran. 


Ajout mort/défaite 

Bonus : une logique de mort/défaite environnementale. Exemple : un piège mortel 

Objectif : Dans le jeu j’ai distingué la mort, du game over. 

Le joueur meurt quand il tombe dans la dead zone, et il perd quand il tombe dans la dead zone avec un nombre de collectible égale à 0.  

J'ai fait notamment plusieurs pièges ou plateforme pouvant faire perdre le joueur. 

Réalisation : Ainsi j’ai fait plusieurs pièges mais le plus marquant est la trap qui disparait avec le temps, que j’ai fait précédemment. Mais ainsi si le joueur tombe dû à ces trappes, il va alors traverser la dead zone, ce qui aura pour conséquence de le faire respawn à un point de spawn (transform) établis au début du niveau. Et également il va perdre un collectible énergie, (son score se réinitialisera dans l'UI) le dernier qu’il a ramassé, et ce collectible réapparaitra dans le monde ainsi il aura littéralement perdu son collectible et devra retourner le chercher dans le niveau. 
(Pour ca j'ai notamment fait un script "manager" et un autre respawn afin de faire réaparaitre le dernier collectible ramassé. Mais j'aborderai plus en détails cela dans l'explication du code)


Ajout mouvement 

Bonus : un nouveau système de déplacement. 

Le saut 

Objectif : avoir un saut unique (pas double saut) à une distance de haut réaliste pas trop haut. 

Réalisation : le jump a été réalisé en une après-midi, à l’aide de tuto trouvé sur internet, ce dernier été assez simple à réaliser. Bien qu'au début j’ai eu un problème de saut infini (n’ayant pas codé la partie avec le raycast détectant le sol). Mais ainsi j’ai principalement passé du temps afin de comprendre clairement le code.  

Le dash 

Objectif : le dash était le deuxième ajout que je voulais faire. Le dash étant un ajout primordial pour un jeu de plateforme. Le but était de réussir à accentuer la vitesse du joueur en restant appuyé sur la touche shift. 

(Mais par rapport aux demandes du projet faire un dash n’était pas forcément nécessaire ayant été demandé seulement un ajout de mouvement, mais par la suite ce dash a été retouché afin d’en faire un collectible.) 

Réalisation : Le dash a été pour moi l’une des réalisations les plus complexe, j’y ai passé plusieurs après-midis, avec beaucoup d’itérations. Au début je me suis aidé de deux tutos, et ait mélangé ces derniers. Mais j’ai eu plusieurs problèmes, les principaux étant par rapport aux collisions, une fois le dash effectué, c’est comme si la vitesse du joueur ignoré les collisions, le joueur se retrouvant à traverser les murs. 

Mais ainsi son fonctionnement est “simple” quand on appuie sur shift, cela déclenche le dash, le joueur va ainsi plus vite dans la direction qu’il décide d’aller avec ZQSD. 

Le dash se déclenche et se joue uniquement quand le joueur reste appuyé sur shift et il ne dure qu’un temps (environ 5 secondes) il ne peut pas être utilisé constamment. 


Effet environnemental 

Bonus : un effet environnemental bénéfique. Exemple : une zone qui nous fait bondir 

Objectif : faire une zone en hauteur (une plateforme) ou quand le joueur arrive sur cette dernière il est projeté en arrière, à un endroit précèdent du niveau afin qu’il n’ait pas à refaire tout le chemin qu’il a fait pour parvenir sur cette plateforme. Assez haut pour accéder à une zone cachée. (Trap qui s’ouvre ouvre zone caché) 

Dans l’idée que j’ai ce serait reprendre le system du jump, et du dash en faisant en sorte d’ajouter une force sur le rigidbody du joueur pour qu’il soit vraiment propulser en arrière et donc de préciser également la direction (forward) 

Réalisation : après de nombreuse itération, le premier système a fonctionné, (inspiration code du saut) application d’une force pour propulser le joueur (vector.3up) seulement en revanche je ne sais pas pourquoi je n’ai pas réussi à faire la même chose mais à le propulser en arrière. Et après d’autres test c’est comme si le joueur rebondissait sur la paroi de la boxe était bloqué. Ainsi à la place j'ai fait un système de téléportation ou quand le joueur, à fait toute une partie/enchainement de plateforme et revenir en arrière serait épuisant, un point de tp à été mis à la dernière plateforme le ramenant avant tous cet enchainement de plateforme pour qu'il n'ai pas à refaire tous le chemin.


Settings 

Bonus : un menu de settings fonctionnel, exemple réglage du volume. 

Pour le moment je n’ai rien fait concernant les settings, préférant me concentre sur le jeu en lui-même, et le level design, et aussi ne savant pas comment faire pour les settings, mais si j’ai le temps j’essayerai de faire des settings sonores avec notamment une barre de son (type bar fill amount) 


Level design 

Material : souhaitait faire un design rappelant tron, ou en tout cas quelque chose de technologique, principalement deux matériaux utiliser, un material noir pour les murs et le sol, et un material représentant une sorte de quadrillage lumineux, détourné en plusieurs couleur utilisé pour les objets avec lesquels on peut interagir (porte plateforme collectible...etc.) 

