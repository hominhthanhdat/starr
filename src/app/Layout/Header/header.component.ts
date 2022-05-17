import { Component, Inject, OnInit, ViewEncapsulation ,ElementRef,ViewChild,ViewChildren,AfterViewInit,Renderer2} from '@angular/core';
import {gsap} from 'gsap';
import { ScrollTrigger } from 'gsap/ScrollTrigger';

gsap.registerPlugin(ScrollTrigger);
@Component({
  selector: 'headerr',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  encapsulation: ViewEncapsulation.None,
})
export class HeaderComponent implements OnInit,AfterViewInit {
  
    @ViewChild('imgs', { static: true }) imageS : ElementRef<HTMLDivElement>
    @ViewChild('imgl', { static: true }) imageL : ElementRef<HTMLDivElement>
    @ViewChild('fillbg', { static: true }) fill : ElementRef<HTMLDivElement>
    @ViewChild('imgSinside', { static: true }) imgSin : ElementRef<HTMLDivElement>
    @ViewChild('imgLinside', { static: true }) imgLin : ElementRef<HTMLDivElement>
    @ViewChild('containerLink', { static: true }) containerLink : ElementRef<HTMLDivElement>
    status: boolean=false;

    getPortfolioOffset(clientY:any) {
      return -(this.containerLink.nativeElement.clientHeight - clientY);
    }
    updateBodyColor(color:string){
      // gsap.to('.fill-background', { backgroundColor: color, ease: 'none'});
      document.documentElement.style.setProperty('--bcg-fill-color', color);
    }
    ngOnInit(): void {
      this.status = false;
      console.log(this.imageL);
      console.log(this.imageS);
      console.log(this.imgLin);
      console.log(this.imgSin);
    }
    ngAfterViewInit(): void {
         
    }
    showMenu(){
      this.status = !this.status;
    }

    createPortfolioHover(e:any){
      const links = this.containerLink.nativeElement.querySelectorAll('a');
      const allLinks = gsap.utils.toArray(links);
      if(e.type === 'mouseenter'){
  
          // change images to the right urls
          // fade in images
          // all siblings to white and fade out
          // active link to white
          // update page background color
  
          const { color, imagelarge, imagesmall } = e.target.dataset;
          const allSiblings = allLinks.filter(item => item !== e.target);
          const tl = gsap.timeline({
              onStart: () => this.updateBodyColor(color)
          });
          tl
              .set(this.imgLin.nativeElement, { backgroundImage: `url(${imagelarge})`})
              .set(this.imgSin.nativeElement, { backgroundImage: `url(${imagesmall})`})
              .to([this.imageL.nativeElement, this.imageS.nativeElement], { autoAlpha: 1})
              .to(allSiblings, { color: '#fff', autoAlpha: 0.2}, 0)
              .to(e.target, {color: '#fff', autoAlpha: 1}, 0);
  
      } else if(e.type === 'mouseleave'){
  
          // fade out images
          // all links back to black
          // change background color back to default 
  
          const tl = gsap.timeline({
              onStart: () => this.updateBodyColor('#ACB7AE')
          });
          tl
              .to([this.imageL.nativeElement, this.imageS.nativeElement], { autoAlpha: 0})
              .to(allLinks, {color: '#000000', autoAlpha: 1}, 0);
  
      }    
    }
    
    createPortfolioMove(e:any){

    const { clientY } = e;

    // move large image
    gsap.to(this.imageL.nativeElement, {
        duration: 1.2, 
        y: this.getPortfolioOffset(clientY)/6,
        ease: 'power3.out'
    });

    // move small image
    gsap.to(this.imageS.nativeElement, {
        duration: 1.5, 
        y: this.getPortfolioOffset(clientY)/3,
        ease: 'power3.out'
    });

    } 

}
   



