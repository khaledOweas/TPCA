import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ZobaComponent } from './zoba.component';

describe('ZobaComponent', () => {
  let component: ZobaComponent;
  let fixture: ComponentFixture<ZobaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ZobaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ZobaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
