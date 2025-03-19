'use client';

import { useState, useEffect, useRef } from 'react';
import { ChevronDown, ChevronUp } from 'lucide-react';
import Input from './input/input';
import Card from './card/card';
import Option from './option/option';

import styles from './dropdown.module.css';
import { DropdownOption } from '@/Interfaces/dropdownOption';



interface DropdownSelectClientProps {
    options: DropdownOption[];
    selectedOption: DropdownOption | null;
    onChange: (option: DropdownOption | null) => void;
}

export default function DropdownSelect({ options, selectedOption = null, onChange }: DropdownSelectClientProps) {
    const [filteredOptions, setFilteredOptions] = useState<DropdownOption[]>(options);
    const [isOpen, setIsOpen] = useState<boolean>(false);
    const [search, setSearch] = useState<string>('');
    const [preSelected, setPreselected] = useState<DropdownOption | null>(null);
    const dropdownRef = useRef<HTMLDivElement>(null);

    useEffect(() => {
        if (search && search.length > 2) {
            const filtered = options.filter((option) => option.label.toLowerCase().includes(search.toLowerCase()));
            setFilteredOptions(filtered);
            if (!preSelected || filtered.findIndex((option) => option.value === preSelected.value)) {
                setPreselected(filtered.length > 0 ? filtered[0] : null);
            }
            setIsOpen(true);
        } else {
            setFilteredOptions(options);
            setPreselected(null);
        }

    }, [search, options]);

    useEffect(() => {
        setIsOpen(false);
        setSearch('');
    }, [selectedOption, options]);

    const handleSearch = (target : string) => {
        if (!target || target.length === 0) {
            onChange(null);
        }

        setSearch(target);
    }

    const getInputValue = () => {
        if ((!search || search.length < 0) && selectedOption){
            return selectedOption.label;
        }
        
        return search;
    }

    const handleClickOutside = (event: MouseEvent) => {
        if (dropdownRef.current && !dropdownRef.current.contains(event.target as Node)) {
            handleOpenClose(false);
        }
    };

    const handleOpenClose = (status: boolean) => {
        if (!status) {
            setSearch('');    
        }

        setIsOpen(status);
    }

    useEffect(() => {
        document.addEventListener('mousedown', handleClickOutside);
        return () => {
            document.removeEventListener('mousedown', handleClickOutside);
        };
    }, []);

    const handleSelected = (option: DropdownOption) => {
        setPreselected(null);
        setSearch('');
        onChange(option);
    }

    const handlePreselected = (e: React.KeyboardEvent<HTMLInputElement>) => {
        if (!preSelected){
            return;
        }

        const currentIndex = filteredOptions.findIndex((option) => option.value === preSelected.value);
        let newIndex = currentIndex;
        if (e.key === "ArrowUp") {
            newIndex -= 1;
        } else if (e.key === "ArrowDown") {
            newIndex += 1;
        } else if (e.key === "Enter") {
            handleSelected({...preSelected});
        } else {
            return;
        }

        e.stopPropagation();
        console.log(newIndex);

        if (newIndex < 0 || newIndex >= filteredOptions.length || newIndex === currentIndex){
            return;
        }

        setPreselected(filteredOptions[newIndex]);
    }

    return (
        <div className={styles['dropdown']} ref={dropdownRef}>
            <label className={styles['dropdown-label']}>
                Select a family from the list
            </label>
            <div className={styles['dropdown-input']} onClick={() => handleOpenClose(!isOpen)}>
                <Input
                    placeholder="Search..."
                    value={getInputValue()}
                    onChange={(e) => handleSearch(e.target.value)}
                    onKeyDown={(e) => handlePreselected(e)}
                    onClick={(e) => {
                        e.stopPropagation();
                        handleOpenClose(true);
                    }}
                />
                {isOpen ? <ChevronUp /> : <ChevronDown />}
            </div>
            {isOpen && (
                <Card>
                    {filteredOptions.length > 0 ? (
                        filteredOptions.map((option) => (
                            <Option
                                key={option.value}
                                isSelected={selectedOption?.value === option.value}
                                isPreselected={preSelected?.value === option.value}
                                onClick={() => handleSelected(option)}>
                                {option.label}
                            </Option>
                        ))
                    ) : (
                        <div className={styles['dropdown-no-options']}>No options found</div>
                    )}
                </Card>
            )}
        </div>
    );
}