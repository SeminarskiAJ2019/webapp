interface DogadajInterface {
  id: number,
  title: string,
  date: string
}

export class Dogadaj {
  id: number;
  datum: string;
  naziv: string;

  constructor(res: DogadajInterface) {
    this.id = res.id;
    this.datum = res.date;
    this.naziv = res.title;
  }
}