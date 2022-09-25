import { Component, OnInit, TemplateRef } from '@angular/core';
import { ZobasVM, ZobaDto, ZobaClient, CreateZobaCommand, UpdateZobaCommand } from '../web-api-client';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-zoba',
  templateUrl: './zoba.component.html',
  styleUrls: ['./zoba.component.scss']
})
export class ZobaComponent implements OnInit {
  debug = true;
  zobas: ZobaDto[] = [];
  newZobaModalRef: BsModalRef;
  newZobaEditor: any = {};
  updateZobaEditor: any = {};
  constructor(private client: ZobaClient, private modalService: BsModalService) {
    client.get().subscribe({
      next: (res) => {
        this.zobas = res.zobas;
      }, error: (err) => {
        console.log(err);
      }
    })
  }

  ngOnInit(): void {
  }


  showNewZobaModal(template: TemplateRef<any>): void {
    this.newZobaModalRef = this.modalService.show(template);
    setTimeout(() => document.getElementById('name').focus(), 250);
  }

  showUpdateZobaModal(template: TemplateRef<any>, Zoba: ZobaDto): void {
    console.log(Zoba);
    this.updateZobaEditor = Zoba;
    this.newZobaModalRef = this.modalService.show(template);
    setTimeout(() => document.getElementById('name').focus(), 250);
  }



  newZobaCancelled(): void {
    this.newZobaModalRef.hide();
    this.newZobaEditor = {};
    this.updateZobaEditor = {};
  }

  addZoba(): void {
    const Zoba = {
      id: 0,
      description: this.newZobaEditor.description,
      age: this.newZobaEditor.age,
      name: this.newZobaEditor.name
    } as ZobaDto;

    this.client.create(Zoba as CreateZobaCommand).subscribe(
      result => {
        Zoba.id = result;
        this.zobas.push(Zoba);
        this.newZobaModalRef.hide();
        this.newZobaEditor = {};
      },
      error => {
        const errors = JSON.parse(error.response);

        if (errors && errors.Title) {
          this.newZobaEditor.error = errors.Title[0];
        }


        setTimeout(() => document.getElementById('name').focus(), 250);
      }
    );
  }


  deleteZoba(id): void {
    console.log(id)
    this.client.delete(id).subscribe({
      next: (res) => {
        console.log(res);
        this.zobas = this.zobas.filter(t => t.id !== id);
      }
    })
  }


  updateZoba(): void {
    const Zoba = {
      id: this.updateZobaEditor.id,
      description: this.updateZobaEditor.description,
      age: this.updateZobaEditor.age,
      name: this.updateZobaEditor.name
    } as ZobaDto;

    this.client.update(this.updateZobaEditor.id, Zoba as UpdateZobaCommand).subscribe(
      result => {
        console.log(result);
        this.newZobaModalRef.hide();
        this.updateZobaEditor = {};
      },
      error => {
        const errors = JSON.parse(error.response);

        if (errors && errors.Title) {
          this.newZobaEditor.error = errors.Title[0];
        }


        setTimeout(() => document.getElementById('name').focus(), 250);
      }
    );
  }
}
