using BossFightMoodleOppgave;

Hero hero = new Hero();
Enemy basicEnemy = new Enemy(true);
Boss boss = new Boss();
hero.Fight(hero, boss);


/*
Hero:                         Boss:
Health: 100                Health: 400
Strength: 20               Strength: 0-30
Stamina: 40                Stamina: 10

Disse to skal i kamp frem til en seirer (motstanderen sin health = 0) konsollen skal logge hvem som angriper,
hvor mye skade som tas og hvor mye liv motstanderen har igjen etter slaget.

I en fight mister GameCharacterene like mye i Health som mostanderen har i Strength.

Hver gang en character bruker metoden Fight() mister de også 10 stamina.

Om Fight() kalles med 0 i stamina må de bruke metoden Recharge() som restorer Stamina til det de hadde da de startet kampen. 
De rundene gamecharacterene må recharge får de ikke utført noe skade.

Styrken til Bossen varierer med en random verdi mellom 0-30 for hver gang Fight() kalles. 
Om dette blir for avansert, la bossen også få en fast styrke på 20.

Eksempel på Konsollens logg når programmet har kjørt ferdig:

Enemy hit hero with 5 damage, hero now has 30 health left.
Hero hit enemy with 20 damage, enemy has 0 health left.
Hero is the winner!
*/