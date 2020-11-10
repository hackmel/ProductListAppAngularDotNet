import { TestBed } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { ProductService } from '../app/services/product.service';
import { Product } from '../app/models/product';
import { Observable } from 'rxjs';
import { of } from 'rxjs';
import { HttpClient } from '@angular/common/http';

describe('AppComponent', () => {
 
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [
        AppComponent
      ],
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

 


});
